using Fakesturant.Web.Models;
using Fakesturant.Web.Models.DTOs;

namespace Fakesturant.Web.Service.IService
{
    public interface IAuthService
    {
        Task<ResponseDto?> RegisterAsync(RegistrationRequestDto registerRequestDto);
        Task<ResponseDto?> LoginAsync(LoginRequestDto loginRequestDto);
        Task<ResponseDto?> AssignRoleAsync(RegistrationRequestDto registerRequestDto);
    }
}
