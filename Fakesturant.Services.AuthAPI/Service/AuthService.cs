using Fakesturant.Services.AuthAPI.Data;
using Fakesturant.Services.AuthAPI.Models;
using Fakesturant.Services.AuthAPI.Models.Dto;
using Fakesturant.Services.AuthAPI.Service.IService;
using Microsoft.AspNetCore.Identity;

namespace Fakesturant.Services.AuthAPI.Service
{
    public class AuthService : IAuthService
    {
        private readonly AppDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AuthService(AppDbContext db, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _userManager = userManager;
            _roleManager = roleManager; 
        }
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
