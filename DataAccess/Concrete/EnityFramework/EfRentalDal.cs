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
                           join cu in context.Customers on re.CustomerId equals cu.Id
                           join us in context.Users on cu.UserId equals us.Id
                           select new RentalDetailDto
                           {
                               Id = re.Id,
                               CarId = ca.Id,
                               UserId = us.Id,
                               CarName = ca.CarName,
                               UserName = us.FirstName,
                               UserLastName = us.LastName,
                               DailyPrice = ca.DailyPrice,
                               CompanyName = cu.CompanyName,
                               RentDate = re.RentDate,
                               ReturnDate = re.ReturnDate
                           };
                return join.ToList();
            }
        }
    }
}
