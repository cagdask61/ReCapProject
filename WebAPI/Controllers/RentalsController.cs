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
    public class RentalsController : ControllerBase
    {

        IRentalService _rentalService;
        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpGet("getrentalall")]
        public IActionResult RentalAll()
        {
            var result = _rentalService.GetAllRental();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getrentaldetail")]
        public IActionResult RentalDetail()
        {
            var result = _rentalService.GetByRentalDetail();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getrentalbyid")]
        public IActionResult RentalById(int rentalId)
        {
            var result = _rentalService.GetRentalById(rentalId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("getrentaladd")]
        public IActionResult RenatalAdd(Rental addRental)
        {
            var result = _rentalService.RentalAdd(addRental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("getrentaldelete")]
        public IActionResult RenatalDelete(Rental deleteRental)
        {
            var result = _rentalService.RentalDelete(deleteRental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("getrentalupdate")]
        public IActionResult RenatalUpdate(Rental updateRental)
        {
            var result = _rentalService.RentalAdd(updateRental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
