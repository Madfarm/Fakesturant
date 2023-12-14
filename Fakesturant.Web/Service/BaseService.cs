using Fakesturant.Web.Models.DTOs;
using Fakesturant.Web.Service.IService;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json.Serialization;
using static Fakesturant.Web.Utility.SD;

namespace Fakesturant.Web.Service
{
    public class BaseService : IBaseService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ITokenProvider _tokenProvider;

        public BaseService(IHttpClientFactory httpClientFactory, ITokenProvider tokenProvider)
        {
            _httpClientFactory = httpClientFactory;
            _tokenProvider = tokenProvider;
        }

        public async Task<ResponseDto?> SendAsync(RequestDto requestDto, bool withBearer = true)
        {
            HttpClient client = _httpClientFactory.CreateClient("FakesturantAPI");
            HttpRequestMessage message = new();
            message.Headers.Add("Accept", "application/json");
            
            if(withBearer)
            {
                var token = _tokenProvider.GetToken();
                message.Headers.Add("Authorization", $"Bearer {token}");
            }

            message.RequestUri = new Uri(requestDto.Url);

            if(requestDto.Data !=  null)
            {
                message.Content = new StringContent(JsonConvert.SerializeObject(requestDto.Data), Encoding.UTF8, "application/json");
            }

            HttpResponseMessage? apiResponse = null;

            switch(requestDto.ApiType)
            {
                case ApiType.POST:
                    message.Method = HttpMethod.Post;
                    break;
                case ApiType.PUT:
                    message.Method = HttpMethod.Put;
                    break;
                case ApiType.DELETE:
                    message.Method = HttpMethod.Delete;
                    break;
                default:
                    message.Method = HttpMethod.Get;
                    break;
            }

            apiResponse = await client.SendAsync(message);

            try
            {
                switch (apiResponse.StatusCode)
                {
                    case System.Net.HttpStatusCode.NotFound:
                        return new() { IsSuccessful = false, Message = "Not Found" };
                    case System.Net.HttpStatusCode.Forbidden:
                        return new() { IsSuccessful = false, Message = "Access Denied" };
                    case System.Net.HttpStatusCode.Unauthorized:
                        return new() { IsSuccessful = false, Message = "Unauthorized" };
                    case System.Net.HttpStatusCode.InternalServerError:
                        return new() { IsSuccessful = false, Message = "Internal Server Error" };
                    default:
                        var apiContent = await apiResponse.Content.ReadAsStringAsync();
                        var apiResponseDto = JsonConvert.DeserializeObject<ResponseDto>(apiContent);
                        return apiResponseDto;

                }
            } catch (Exception ex)
            {
                var dto = new ResponseDto
                {
                    Message = ex.Message.ToString(),
                    IsSuccessful = false
                };
                return dto;
            }
        }
    }
}
