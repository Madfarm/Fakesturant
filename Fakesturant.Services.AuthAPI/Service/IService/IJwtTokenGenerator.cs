using Fakesturant.Services.AuthAPI.Models;

namespace Fakesturant.Services.AuthAPI.Service.IService
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser);
    }
}
