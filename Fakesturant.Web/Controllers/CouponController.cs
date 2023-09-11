using Microsoft.AspNetCore.Mvc;

namespace Fakesturant.Web.Controllers
{
    public class CouponController : Controller
    {
        public IActionResult CouponIndex()
        {
            return View();
        }
    }
}
