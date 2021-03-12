using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EnityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, RentACarContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetail()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var join = from cu in context.Customers
                           join us in context.Users on cu.UserId equals us.Id
                           select new CustomerDetailDto
                           {
                               CustomerName = us.FirstName,
                               CustomerLastName = us.LastName,
                               CompanyName = cu.CompanyName
                           };
                return join.ToList();
                           
            }
            
        }
    }
}
