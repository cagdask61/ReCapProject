using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.FileManager;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {

        ICarImageDal _carImageDal;
        IFileManager _fileManager;
        public CarImageManager(ICarImageDal carImageDal,IFileManager fileManager)
        {
            _carImageDal = carImageDal;
            _fileManager = fileManager;
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IResult CarImageAdd(IFormFile addFile, CarImage carImage)
        {
            var result = BusinessRules.Run(CheckImageLimitExceeded(carImage.CarId));
            if (result != null)
            {
                return result;
            }
            carImage.ImagePath = _fileManager.AddImage(addFile);
            carImage.Date = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.CarImageAdded);
        }

        public IResult CarImageDelete(CarImage carImage)
        {
            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.CarImageDeleted);
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IResult CarImageUpdate(IFormFile updateFile, CarImage carImage)
        {
            var result = BusinessRules.Run(CheckImageLimitExceeded(carImage.CarId));
            if (result != null)
            {
                return result;
            }
            carImage.ImagePath = _fileManager.UpdateImage(_carImageDal.Get(p=>p.Id == carImage.Id).ImagePath,updateFile);
            carImage.Date = DateTime.Now;
            _carImageDal.Update(carImage);
            return new SuccessResult(Messages.CarImageUpdated);
        }

        public IDataResult<List<CarImage>> GetCarImageAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<CarImage> GetCarImageId(int CarImageId)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(p=>p.Id == CarImageId));
        }

        private IResult CheckImageLimitExceeded(int carId)
        {
            var result = _carImageDal.GetAll(c=>c.CarId == carId).Count;
            if (result >= 5)
            {
                return new ErrorResult(Messages.CarImageLimitExceeded);
            }
            return new SuccessResult();
        }

        private IDataResult<List<CarImage>> CheckedIfCarImageNull(int Id)
        {

            try
            {
                string path = @"\wwwroot\DefaultImage\DefaultImage.png";
                var result = _carImageDal.GetAll(c => c.CarId == Id).Any();
                if (!result)
                {
                    List<CarImage> carImage = new List<CarImage>();
                    carImage.Add(new CarImage { CarId = Id, ImagePath = path, Date = DateTime.Now });
                    return new SuccessDataResult<List<CarImage>>(carImage);
                }

            }
            catch (Exception exx)
            {
                return new ErrorDataResult<List<CarImage>>(exx.Message);
            }
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(c=>c.CarId == Id).ToList());
            
        } 
    }
}
