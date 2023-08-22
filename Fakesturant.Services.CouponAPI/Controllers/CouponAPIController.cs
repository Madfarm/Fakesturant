using Fakesturant.Services.CouponAPI.Models;
using Fakesturant.Services.CouponAPI.NewFolder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fakesturant.Services.CouponAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponAPIController : ControllerBase
    {
        private readonly AppDbContext _db;

        public CouponAPIController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public object Get()
        {
            try
            {
                IEnumerable<Coupon> objList = _db.Coupons.ToList();
                return objList;
            }
            catch (Exception ex) 
            {

            }

            return null;
        }

        [HttpGet("{id}")]
        public object GetById(int id) 
        {
            try
            {
                Coupon obj = _db.Coupons.First(c => c.CouponId == id);
                return obj;
            }
            catch (Exception ex)
            {

            }

            return null;
        }

    }
}
