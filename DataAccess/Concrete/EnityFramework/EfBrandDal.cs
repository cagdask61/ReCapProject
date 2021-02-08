using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EnityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, RentACarContext>, IBrandDal
    {

        //Brand e özel method
        public List<Brand> GetBrandAll()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = context.Brands.ToList();
                return result.ToList();
            }
        }
    }
}
