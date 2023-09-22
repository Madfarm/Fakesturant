using Fakesturant.Services.AuthAPI.Models.Dto;
using Fakesturant.Services.AuthAPI.Service.IService;

namespace Fakesturant.Services.AuthAPI.Service
{
    public class AuthService : IAuthService
    {
        public Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> Regiser(RegistrationRequestDto registrationRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}
