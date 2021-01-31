using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();

        List<Car> GetById(int Id);

        List<Car> GetByDailyPrice();

        List<Car> GetByDailyPriceDescending();

        List<Car> GetByModelYear();

        List<Car> GetByModelYearDescending();

        void GetCarAdd(Car car);

        void GetCarDelete(Car car);

        void GetCarUpdate(Car car);
    }
}
