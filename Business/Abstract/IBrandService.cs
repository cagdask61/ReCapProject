using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetBrandAll();

        IDataResult<Brand> GetBrandId(int Id);

        IResult GetBrandAdd(Brand brand);

        IResult GetBrandDelete(Brand brand);

        IResult GetBrandUpdate(Brand brand);
    }
}
