using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
        }

        [SecuredOperation("admin,user,moderator")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("IProductService.Get")]
        public IResult GetCarAdd(Car car)
        {
            var result = BusinessRules.Run(CheckCarNameExists(car.CarName));
            if (result != null)
            {
                return result;
            }

            _carDal.Add(car);
            return new SuccessResult();

        }

        [SecuredOperation("admin")]
        public IResult GetCarDelete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        [SecuredOperation("admin,moderator")]
        [ValidationAspect(typeof(CarValidator))]
        public IResult GetCarUpdate(Car car)
        {
            var result = BusinessRules.Run(CheckCarNameExists(car.CarName));
            if (result != null)
            {
                return result;
            }

            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        [CacheAspect(duration: 15)]
        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {

            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == brandId));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {

            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c=>c.ColorId == colorId));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetail()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetail());

        }

        public IDataResult<Car> GetCarId(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == carId), Messages.CarById);
        }

        public IDataResult<List<Car>> GetCarSearch(string carName)
        {
            var result = BusinessRules.Run(CheckCarNameIsNull(carName));
            if (result != null)
            {
                return (IDataResult<List<Car>>)result;
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c=>c.CarName == carName));
        }

        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Car car)
        {
            throw new NotImplementedException();
        }

        private IResult CheckCarNameExists(string carName)
        {
            var result = _carDal.GetAll(p => p.CarName == carName).Any();
            if (result)
            {
                return new ErrorResult(Messages.CarNameAlreadyExists);
            }
            return new SuccessResult();
        }

        private IDataResult<List<Car>> CheckCarNameIsNull(string valueName)
        {
            var result = string.IsNullOrEmpty(valueName);
            if (result)
            {
                return new ErrorDataResult<List<Car>>();
            }
            return new SuccessDataResult<List<Car>>();
        }
        
    }
}
