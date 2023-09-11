using Microsoft.AspNetCore.Mvc;

namespace Fakesturant.Web.Controllers
{
    public class CouponController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
