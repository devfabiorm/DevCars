using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCars.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }

        [HttpPost("{id}")]
        public IActionResult PostOrder(int id)
        {
            return Ok();
        }

        [HttpGet("{id}/orders/{ordersId}")]
        public IActionResult GetOrder(int id, int ordersId)
        {
            return Ok();
        }
    }
}
