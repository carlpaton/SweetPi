using Microsoft.AspNetCore.Mvc;

namespace SweetPi.Api.Controllers
{
    public class PingController : Controller
    {
        [HttpGet("/ping")]
        public IActionResult Get()
        {
            return Ok("SweetPi.Api is running...");
        }
    }
}
