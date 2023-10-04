using Fakesturant.Services.AuthAPI.Models;
using Fakesturant.Services.AuthAPI.Service.IService;

namespace Fakesturant.Services.AuthAPI.Service
{
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        private readonly JwtOptions _jwtOptions;

        public JwtTokenGenerator(JwtOptions jwtOptions)
        {
            _jwtOptions = jwtOptions;
        }
        public string GenerateToken(ApplicationUser applicationUser)
        {
            throw new NotImplementedException();
        }
    }
}
