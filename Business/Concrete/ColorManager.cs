using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        [ValidationAspect(typeof(ColorValidator))]
        public IResult GetColorAdd(Color color)
        {
            
            _colorDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }

        public IDataResult<List<Color>> GetColorAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetColorAll(),Messages.ColorsListed);

        }

        public IResult GetColorDelete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);
            
        }

        public IDataResult<Color> GetColorId(int Id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(co=>co.Id == Id),Messages.ColorById);
        }

        public IResult GetColorUpdate(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
        }
    }
}
