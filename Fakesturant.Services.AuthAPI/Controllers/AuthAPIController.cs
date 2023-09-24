using Fakesturant.Services.AuthAPI.Models;
using Fakesturant.Services.AuthAPI.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fakesturant.Services.AuthAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthAPIController : ControllerBase
    {
        [HttpPost("register")]
        public async Task<IActionResult> Register(RegistrationRequestDto registrationRequestDto)
        {
            ApplicationUser user = new()
            {
                
            };
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequestDto loginRequestDto)
        {
            return Ok();
        }

    }
}
