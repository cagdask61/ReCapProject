using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {

        ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("getcustomerall")]
        public IActionResult GetAll()
        {
            var result = _customerService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getcustomerid")]
        public IActionResult CustomerbyId(int customerId)
        {
            var result = _customerService.GetById(customerId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("getcustomeradd")]
        public IActionResult CustomerAdd(Customer addCustomer)
        {
            var result = _customerService.GetCustomerAdd(addCustomer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("getcustomerdelete")]
        public IActionResult CustomerDelete(Customer deleteCustomer)
        {
            var result = _customerService.GetCustomerDelete(deleteCustomer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("getcustomerupdate")]
        public IActionResult CustomerUpdate(Customer updateCustomer)
        {
            var result = _customerService.GetCustomerUpdate(updateCustomer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getcustomerdetail")]
        public IActionResult CustomerDetail()
        {
            var result = _customerService.GetCustomerDetail();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
