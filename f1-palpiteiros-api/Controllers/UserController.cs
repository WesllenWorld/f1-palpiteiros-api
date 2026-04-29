using Microsoft.AspNetCore.Mvc;
using F1Palpiteiros.Services;

namespace F1Palpiteiros.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

       
        [HttpPost("login")]
        public void login() {
            //_userService.();
        }
    }
}