using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
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
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarsListed);
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult GetCarAdd(Car car)
        {

            _carDal.Add(car);

            return new SuccessResult(Messages.CarAdded);

        }

        public IResult GetCarDelete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IResult GetCarUpdate(Car car)
        {

            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        public IDataResult<Car> GetCarsByBrandId(int brandId)
        {

            return new SuccessDataResult<Car>(_carDal.Get(c => c.BrandId == brandId));
        }

        public IDataResult<Car> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.ColorId == colorId));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetail()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetail());

        }

        public IDataResult<Car> GetCarId(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c=>c.Id == carId), Messages.CarById);
        }

        public IDataResult<Car> GetCarSearch(string carName)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p=>p.CarName == carName),Messages.CarsListed);
        }
    }
}
