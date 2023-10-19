using Fakesturant.Web.Models;
using Fakesturant.Web.Service.IService;
using Fakesturant.Web.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Fakesturant.Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            LoginRequestDto loginRequestDto = new();
            return View(loginRequestDto);
        }

        [HttpGet]
        public IActionResult Register()
        {
            var roleList = new List<SelectListItem>()
            { 
                new SelectListItem{ Text = SD.RoleAdmin, Value = SD.RoleAdmin },
                new SelectListItem{ Text = SD.RoleCustomer, Value = SD.RoleCustomer }
            }; 

            ViewBag.RoleList = roleList;
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegistrationRequestDto obj)
        {
            var roleList = new List<SelectListItem>()
            {
                new SelectListItem{ Text = SD.RoleAdmin, Value = SD.RoleAdmin },
                new SelectListItem{ Text = SD.RoleCustomer, Value = SD.RoleCustomer }
            };

            ViewBag.RoleList = roleList;
            return View();
        }


        public IActionResult Logout()
        {
            return View();
        }
    }
}
