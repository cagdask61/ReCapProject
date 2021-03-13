using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EnityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetail()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var join = from re in context.Rentals
                           join ca in context.Cars on re.CarId equals ca.Id
                           join co in context.Colors on ca.ColorId equals co.Id
                           join br in context.Brands on ca.BrandId equals br.Id
                           join cu in context.Customers on re.CustomerId equals cu.Id
                           join us in context.Users on cu.UserId equals us.Id
                           select new RentalDetailDto
                           {
                               Id = re.Id,
                               BrandName = br.BrandName,
                               ColorName = co.ColorName,
                               CarName = ca.CarName,
                               FirstName = us.FirstName,
                               LastName = us.LastName,
                               CompanyName = cu.CompanyName,
                               ModelYear = ca.ModelYear,
                               DailyPrice = ca.DailyPrice,
                               RentDate = re.RentDate,
                               ReturnDate = re.ReturnDate,
                               Description = ca.Description
                           };
                
                return join.ToList();
            }
        }
    }
}
