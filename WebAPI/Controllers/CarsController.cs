using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getcarall")]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getcarbyid")]
        public IActionResult GetCarById(int carId)
        {
            var result = _carService.GetCarId(carId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        //
        [Route("getcarbyId/{carId}")]
        [HttpGet()]
        public IActionResult GetCarByIdRoute(int carId)
        {
            var result = _carService.GetCarId(carId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getcarbybrandid")]
        public IActionResult GetCarsByBrandId(int brandId)
        {
            var result = _carService.GetCarsByBrandId(brandId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        //
        [Route("getcarsbybrand/brandid/{brandId}")]
        [HttpGet()]
        public IActionResult GetCarsByBrandIdRoute(int brandId)
        {
            var result = _carService.GetCarsByBrandId(brandId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getcarsbycolorid")]
        public IActionResult GetCarsByColorId(int colorId)
        {
            var result = _carService.GetCarsByColorId(colorId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        //
        [Route("getcarsbycolor/colorid/{colorId}")]
        [HttpGet()]
        public IActionResult GetCarsByColorIdRoute(int colorId)
        {
            var result = _carService.GetCarsByColorId(colorId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getcardetail")]
        public IActionResult CarDetail()
        {
            var result = _carService.GetCarDetail();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getcarsearch")]
        public IActionResult GetCarSearch(string carName)
        {
            var result = _carService.GetCarSearch(carName);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        //
        [Route("getcarsearch/carname/{carName}")]
        [HttpGet()]
        public IActionResult GetCarSearchRoute(string carName)
        {
            var result = _carService.GetCarSearch(carName);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("getcaradd")]
        public IActionResult CarAdd(Car addCar)
        {
            var result = _carService.GetCarAdd(addCar);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("getcardelete")]
        public IActionResult CarDelete(Car deleteCar)
        {
            var result = _carService.GetCarDelete(deleteCar);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("getcarupdate")]
        public IActionResult CarUpdate(Car updateCar)
        {
            var result = _carService.GetCarUpdate(updateCar);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
