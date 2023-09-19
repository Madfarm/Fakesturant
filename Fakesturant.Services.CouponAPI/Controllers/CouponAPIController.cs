using AutoMapper;
using Fakesturant.Services.CouponAPI.Models;
using Fakesturant.Services.CouponAPI.Models.Dto;
using Fakesturant.Services.CouponAPI.NewFolder;
using Microsoft.AspNetCore.Mvc;

namespace Fakesturant.Services.CouponAPI.Controllers
{
    [Route("api/cou3pon")]
    [ApiController]
    public class CouponAPIController : ControllerBase
    {
        private readonly AppDbContext _db;
        private ResponseDto _response;
        private IMapper _mapper;

        public CouponAPIController(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _response = new ResponseDto();
            _mapper = mapper;
        }

        [HttpGet]
        public ResponseDto Get()
        {
            try
            {
                IEnumerable<Coupon> objList = _db.Coupons.ToList();
                _response.Result = _mapper.Map<IEnumerable<CouponDto>>(objList);
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
                _response.Result = _mapper.Map<CouponDto>(obj);
               
            }
            catch (Exception ex)
            {
                _response.IsSuccssful = false;
                _response.Message = ex.Message;
            }

            return _response;
        }

        [HttpGet("GetByCode/{code}")]
        public ResponseDto GetByCode(string code)
        {
            try
            {
                Coupon obj = _db.Coupons.FirstOrDefault(c => c.CouponCode.ToLower() == code.ToLower());
                _response.Result = _mapper.Map<CouponDto>(obj);

            }
            catch (Exception ex)
            {
                _response.IsSuccssful = false;
                _response.Message = ex.Message;
            }

            return _response;
        }

  
        [HttpPost]
        public ResponseDto Post([FromBody] CouponDto couponDto)
        {
            try
            {
                Coupon obj = _mapper.Map<Coupon>(couponDto);
                _db.Coupons.Add(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<CouponDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccssful = false;
                _response.Message = ex.Message;
            }

            return _response;
        }

        [HttpPut]
        public ResponseDto Put([FromBody] CouponDto couponDto)
        {
            try
            {
                Coupon obj = _mapper.Map<Coupon>(couponDto);
                _db.Coupons.Update(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<CouponDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccssful = false;
                _response.Message = ex.Message;
            }

            return _response;
        }

        [HttpDelete("{id}")]
        public ResponseDto Delete(int id)
        {
            try
            {
                Coupon obj = _db.Coupons.First(c => c.CouponId == id);
                _db.Coupons.Remove(obj);
                _db.SaveChanges();
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
