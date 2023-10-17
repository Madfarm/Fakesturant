using Microsoft.AspNetCore.Mvc;

namespace Fakesturant.Web.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
