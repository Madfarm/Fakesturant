using Fakesturant.Web.Models;
using Fakesturant.Web.Models.DTOs;
using Fakesturant.Web.Service.IService;
using Fakesturant.Web.Utility;

namespace Fakesturant.Web.Service
{
    public class AuthService : IAuthService
    {
        private readonly IBaseService _baseService;

        public AuthService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<ResponseDto?> AssignRoleAsync(RegistrationRequestDto registerRequestDto)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseDto?> LoginAsync(LoginRequestDto loginRequestDto)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseDto?> RegisterAsync(RegistrationRequestDto registerRequestDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Utility.SD.ApiType.POST,
                Url = SD.AuthAPIBase + "/api/auth/register",
                Data = registerRequestDto
            });
        }
    }
}
