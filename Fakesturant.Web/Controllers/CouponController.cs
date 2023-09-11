using Fakesturant.Web.Models;
using Fakesturant.Web.Models.DTOs;
using Fakesturant.Web.Service;
using Fakesturant.Web.Service.IService;
using Microsoft.AspNetCore.Mvc;

namespace Fakesturant.Web.Controllers
{
    public class CouponController : Controller
    {
        private readonly ICouponService _couponService;
        public CouponController(ICouponService couponService)
        {
            _couponService = couponService; 
        }
        public async Task<IActionResult> CouponIndex()
        {
            List<CouponDto>? list = new();
            ResponseDto? response = await _couponService.GetCouponsAsync();
            return View();
        }
    }
}
