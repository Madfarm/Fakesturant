using Fakesturant.Web.Models;
using Fakesturant.Web.Models.DTOs;
using Fakesturant.Web.Service.IService;

namespace Fakesturant.Web.Service
{
    public class AuthService : IAuthService
    {
        public Task<ResponseDto?> AssignRole(RegistrationRequestDto request)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> Login(LoginRequestDto request)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> Register(RegistrationRequestDto request)
        {
            throw new NotImplementedException();
        }
    }
}
