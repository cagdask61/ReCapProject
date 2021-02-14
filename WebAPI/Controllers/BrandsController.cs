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
    public class BrandsController : ControllerBase
    {
        IBrandService _brandService;
        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet("getbrandall")]
        public IActionResult GetAll()
        {
            var result = _brandService.GetBrandAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbrandbyid")]
        public IActionResult BrandById(int brandId)
        {
            var result = _brandService.GetBrandId(brandId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("getbrandadd")]
        public IActionResult BrandAdd(Brand addBrand)
        {
            var result = _brandService.GetBrandAdd(addBrand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("getbranddelete")]
        public IActionResult BrandDelete(Brand deleteBrand)
        {
            var result = _brandService.GetBrandDelete(deleteBrand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("getbrandupdate")]
        public IActionResult BrandUpdate(Brand updateBrand)
        {
            var result = _brandService.GetBrandUpdate(updateBrand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
