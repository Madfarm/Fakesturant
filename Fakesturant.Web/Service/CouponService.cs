using Fakesturant.Web.Models;
using Fakesturant.Web.Models.DTOs;

namespace Fakesturant.Web.Service
{
    public class CouponService : ICouponService
    {
        private readonly BaseService _baseService;

        public CouponService(BaseService baseService) 
        {
            _baseService = baseService;
        }
        public Task<ResponseDto?> CreateCouponAsync(CouponDto couponDto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> DeleteCouponAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseDto?> GetAllCoupon()
        {
            throw new NotImplementedException();
            //await _baseService.SendAsync()
        }

        public Task<ResponseDto?> GetCouponAsync(string CouponCode)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> GetCouponByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto?> UpdateCouponAsync(CouponDto couponDto)
        {
            throw new NotImplementedException();
        }
    }
}
