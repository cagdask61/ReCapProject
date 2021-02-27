using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EnityFramework
{
    public class EfCarImageDal : EfEntityRepositoryBase<CarImage,RentACarContext>,ICarImageDal
    {
    }
}
