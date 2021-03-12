using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public  interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IDataResult<Customer> GetById(int customerId);
        IResult GetCustomerAdd(Customer customer);
        IResult GetCustomerDelete(Customer customer);
        IResult GetCustomerUpdate(Customer customer);

        IDataResult<List<CustomerDetailDto>> GetCustomerDetail();
    }
}
