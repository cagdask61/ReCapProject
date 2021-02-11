using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetColorAll();

        IResult GetColorAdd(Color color);

        IResult GetColorDelete(Color color);

        IResult GetColorUpdate(Color color);
    }
}
