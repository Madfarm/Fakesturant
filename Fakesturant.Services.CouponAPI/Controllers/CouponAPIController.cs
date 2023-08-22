using Fakesturant.Services.CouponAPI.Models;
using Fakesturant.Services.CouponAPI.Models.Dto;
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
        private ResponseDto _response;

        public CouponAPIController(AppDbContext db)
        {
            _db = db;
            _response = new ResponseDto();
        }

        [HttpGet]
        public ResponseDto Get()
        {
            try
            {
                IEnumerable<Coupon> objList = _db.Coupons.ToList();
                _response.Result = objList;
            }
            catch (Exception ex) 
            {
                _response.IsSuccssful = false;
                _response.Message = ex.Message;
            }

            return _response;
        }

        [HttpGet("{id}")]
        public ResponseDto GetById(int id) 
        {
            try
            {
                Coupon obj = _db.Coupons.First(c => c.CouponId == id);
                _response.Result = obj;
                return _response;
            }
            catch (Exception ex)
            {
                _response.IsSuccssful = false;
                _response.Message = ex.Message;
            }

            return _response;
        }

    }
}
