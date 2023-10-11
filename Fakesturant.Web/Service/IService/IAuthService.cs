using Fakesturant.Web.Models;
using Fakesturant.Web.Models.DTOs;

namespace Fakesturant.Web.Service.IService
{
    public interface IAuthService
    {
        Task<ResponseDto?> Register(RegistrationRequestDto request);
        Task<ResponseDto?> Login(LoginRequestDto request);
        Task<ResponseDto?> AssignRole(RegistrationRequestDto request);
    }
}
