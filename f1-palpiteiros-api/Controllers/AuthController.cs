using Microsoft.AspNetCore.Mvc;
using F1Palpiteiros.DTOs;

namespace F1Palpiteiros.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        public AuthController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult register([FromForm] RegisterUserDTO registerUserDTO)
        {
            return Ok("Register endpoint");
        }
    }
}
