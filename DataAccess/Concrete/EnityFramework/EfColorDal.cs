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
    public class EfColorDal : EfEntityRepositoryBase<Color, RentACarContext>, IColorDal
    {

        //Color a özel method
        public List<Color> GetColorAll()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = context.Colors;
                return result.ToList();
            }
        }
    }
}
