using Microsoft.AspNetCore.Identity;

namespace Fakesturant.Services.AuthAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
