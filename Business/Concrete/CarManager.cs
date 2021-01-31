using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetByDailyPrice()
        {
            return _carDal.GetByDailyPrice();
        }

        public List<Car> GetByDailyPriceDescending()
        {
            return _carDal.GetByDailyPriceDescending();
        }

        public List<Car> GetById(int Id)
        {
            return _carDal.GetById(Id);
        }

        public List<Car> GetByModelYear()
        {
            return _carDal.GetByModelYear();
        }

        public List<Car> GetByModelYearDescending()
        {
            return _carDal.GetByModelYearDescending();
        }

        public void GetCarAdd(Car car)
        {
            _carDal.Add(car);
        }

        public void GetCarDelete(Car car)
        {
            _carDal.Delete(car);
        }

        public void GetCarUpdate(Car car)
        {
            _carDal.Update(car);
        }

        
    }
}
