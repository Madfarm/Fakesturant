using Fakesturant.Services.AuthAPI.Models.Dto;

namespace Fakesturant.Services.AuthAPI.Service.IService
{
    public interface IAuthService
    {
        Task<UserDto> Regiser(RegistrationRequestDto registrationRequestDto);
        Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto);
    }
}
