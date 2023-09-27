using Fakesturant.Services.AuthAPI.Models.Dto;
using Fakesturant.Services.AuthAPI.Service.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fakesturant.Services.AuthAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthAPIController : ControllerBase
    {
        private readonly IAuthService _authService;
        protected ResponseDto _response;

        public AuthAPIController(IAuthService authService)
        {
            _authService = authService;
            _response = new();
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegistrationRequestDto model)
        {
            var errorMessage = await _authService.Register(model);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                _response.IsSuccessful = false;
                _response.Message = errorMessage;
                return BadRequest(_response);
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login()
        {
            return Ok();
        }

    }
}
