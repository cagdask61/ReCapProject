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

        public void GetCarAdd(Car car)
        {
            try
            {
                if (car.CarName.Length >= 2 && car.DailyPrice > 0)
                {

                    _carDal.Add(car);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(car.CarName+" İsimli araba eklendi");
                    Console.ResetColor();
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
            finally
            {

                Console.WriteLine(car.Id + " " + car.CarName + " İşleminiz alındı");

            }
        }

        public void GetCarDelete(Car car)
        {
            _carDal.Delete(car);
        }

        public void GetCarUpdate(Car car)
        {

            _carDal.Update(car);
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {

            return _carDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
        }


    }
}
