using Fakesturant.Web.Models.DTOs;

namespace Fakesturant.Web.Service.IService
{
    public interface IBaseService
    {
       Task<ResponseDto?> SendAsync(RequestDto requestDto);
    }
}
