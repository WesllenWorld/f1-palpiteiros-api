using Microsoft.AspNetCore.Mvc;
using F1Palpiteiros.DTOs;

namespace F1Palpiteiros.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        

        /*
        [HttpPost]
        public IActionResult register([FromForm] RegisterUserDTO registerUserDTO)
        {
            return Ok("Register endpoint");
        }*/
        [HttpGet]
        public string register()
        {
            return "Register endpoint";
        }

    }
}
