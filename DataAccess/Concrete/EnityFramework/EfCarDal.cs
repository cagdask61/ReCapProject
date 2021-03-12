using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EnityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetail()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var Join = from c in context.Cars
                           join co in context.Colors on c.Id equals co.Id
                           join b in context.Brands on c.Id equals b.Id
                           select new CarDetailDto
                           {
                               ColorName = co.ColorName,
                               BrandName = b.BrandName,
                               CarName = c.CarName,
                               DailyPrice = c.DailyPrice,
                               Description = c.Description,
                               ModelYear = c.ModelYear
                               
                           };

                return Join.ToList();
            }
        }
    }
}
