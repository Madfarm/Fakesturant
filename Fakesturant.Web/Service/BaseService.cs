using Fakesturant.Web.Models.DTOs;
using Fakesturant.Web.Service.IService;

namespace Fakesturant.Web.Service
{
    public class BaseService : IBaseService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BaseService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ResponseDto?> SendAsync(RequestDto requestDto)
        {
            throw new NotImplementedException();
        }
    }
}
