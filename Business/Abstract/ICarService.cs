using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();

        
        List<Car> GetCarsByBrandId(int brandId);

        List<Car> GetCarsByColorId(int colorId);



        void GetCarAdd(Car car);

        void GetCarDelete(Car car);

        void GetCarUpdate(Car car);

        List<CarDetailDto> GetCarDetail();

    }
}
