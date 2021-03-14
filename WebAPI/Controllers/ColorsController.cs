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
    public class ColorsController : ControllerBase
    {

        IColorService _colorService;
        public ColorsController(IColorService colorService)
        {
            _colorService = colorService;
        }

        [HttpGet("getcolorall")]
        public IActionResult GetAll()
        {
            var result = _colorService.GetColorAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        //
        [Route("getcolors/colorsall")]
        [HttpGet()]
        public IActionResult GetColorsAllRoute()
        {
            var result = _colorService.GetColorAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getcolorbyid")]
        public IActionResult ColorById(int colorId)
        {
            var result = _colorService.GetColorId(colorId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        //
        [Route("getcolorbyid/{colorId}")]
        [HttpGet()]
        public IActionResult ColorByIdRoute(int colorId)
        {
            var result = _colorService.GetColorId(colorId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("getcoloradd")]
        public IActionResult CarAdd(Color addColor)
        {
            var result = _colorService.GetColorAdd(addColor);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("getcolordelete")]
        public IActionResult CarDelete(Color deleteColor)
        {
            var result = _colorService.GetColorDelete(deleteColor);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("getcolorupdate")]
        public IActionResult CarUpdate(Color updateColor)
        {
            var result = _colorService.GetColorUpdate(updateColor);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
