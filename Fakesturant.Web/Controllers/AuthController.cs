using Fakesturant.Web.Service.IService;
using Microsoft.AspNetCore.Mvc;

namespace Fakesturant.Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        
    }
}
