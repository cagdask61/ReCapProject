using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        
        IDataResult<Car> GetCarsByBrandId(int brandId);

        IDataResult<Car> GetCarsByColorId(int colorId);

        IResult GetCarAdd(Car car);

        IResult GetCarDelete(Car car);

        IResult GetCarUpdate(Car car);

        IDataResult<List<CarDetailDto>> GetCarDetail();

    }
}
