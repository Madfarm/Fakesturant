using Microsoft.Identity.Client;

namespace Fakesturant.Services.AuthAPI.Models.Dto
{
    public class ResponseDto
    {
        public object? Result { get; set; }
        public bool IsSuccessful { get; set; } = true;
        public string Message { get; set; } = "";
    }
}
