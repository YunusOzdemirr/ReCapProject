using Business.Abstract;
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
    public class RentalssController : ControllerBase
    {
        IRentalsService _rentalsService;

        public RentalssController(IRentalsService rentalsService)
        {
            _rentalsService = rentalsService;
        }
        [HttpGet("getall")]
        public IActionResult getall()
        {
            var result = _rentalsService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
