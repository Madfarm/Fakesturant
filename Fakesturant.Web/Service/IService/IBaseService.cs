using Fakesturant.Web.Models.DTOs;

namespace Fakesturant.Web.Service.IService
{   
    //Interface for base service
    public interface IBaseService
    {
       Task<ResponseDto?> SendAsync(RequestDto requestDto, bool withBearer = true);
    }
}
