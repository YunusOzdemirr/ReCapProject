using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagessController : ControllerBase
    {
        ICarImagesService _carImagesService;
        public CarImagessController(ICarImagesService carImagesService)
        {
            _carImagesService = carImagesService;
        }

        [HttpPost("add")]
        public IActionResult add(CarImages car)
        {
            var file = Path.Combine(Directory.GetCurrentDirectory(),
                            "MyImages", "images");
            return PhysicalFile(file, $"MyImages/image/{car.ImagePath}");
            var result = _carImagesService.Add(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

