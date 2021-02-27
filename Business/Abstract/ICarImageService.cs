using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult CarImageAdd(IFormFile addFile,CarImage carImage);

        IResult CarImageDelete(CarImage carImage);

        IResult CarImageUpdate(IFormFile updateFile, CarImage carImage);

        IDataResult<CarImage> GetCarImageId(int CarImageId);

        IDataResult<List<CarImage>> GetCarImageAll();
    }
}
