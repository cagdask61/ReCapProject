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
    public class CarImagesController : ControllerBase
    {

        ICarImageService _carImageService;
        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }

        [HttpGet("getImagesAll")]
        public IActionResult GetAll()
        {
            var result = _carImageService.GetCarImageAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("getcarimageadd")]
        public IActionResult CarImageAdd([FromForm(Name = ("Image"))] IFormFile file, [FromForm] CarImage carImage)
        {
            var result = _carImageService.CarImageAdd(file, carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("getcarimagedelete")]
        public IActionResult CarImageDelete([FromForm(Name = ("Id"))] int Id)
        {
            var carImage = _carImageService.GetCarImageId(Id).Data;
            var result = _carImageService.CarImageDelete(carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("getcarimageupdate")]
        public IActionResult CarImageUpdate([FromForm(Name = ("Image"))] IFormFile file, [FromForm(Name ="Id")] int Id)
        {
            var carImage = _carImageService.GetCarImageId(Id).Data;
            var result = _carImageService.CarImageUpdate(file,carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getimagesbyId")]
        public IActionResult GetImages([FromForm(Name =("CarId"))] int carId)
        {
            var result = _carImageService.GetCarImageId(carId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

      
    }
}
