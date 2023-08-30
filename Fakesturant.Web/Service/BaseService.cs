using Fakesturant.Web.Models.DTOs;
using Fakesturant.Web.Service.IService;
using System.Text.Json.Serialization;

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
            HttpClient client = _httpClientFactory.CreateClient("FakestruantAPI");
            HttpRequestMessage message = new();
            message.Headers.Add("Accept", "application/json");
            // token to be implemented later

            message.RequestUri = new Uri(requestDto.Url);

            if(requestDto.Data !=  null)
            {
                //message.Content = new StringContent(JsonConverter.)
            }
        }
    }
}
