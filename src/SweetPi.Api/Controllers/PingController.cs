using Microsoft.AspNetCore.Mvc;
using System;

namespace SweetPi.Api.Controllers
{
    public class PingController : Controller
    {
        [HttpGet("/ping")]
        public IActionResult Get()
        {
            return Ok($"SweetPi.Api is running... {DateTime.Now}");
        }
    }
}
