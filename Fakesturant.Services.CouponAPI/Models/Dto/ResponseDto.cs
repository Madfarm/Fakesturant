using Microsoft.Identity.Client;

namespace Fakesturant.Services.CouponAPI.Models.Dto
{
    public class ResponseDto
    {
        public object? Result { get; set; }
        public bool IsSuccssful { get; set; }
        public string Message { get; set; }
    }
}
