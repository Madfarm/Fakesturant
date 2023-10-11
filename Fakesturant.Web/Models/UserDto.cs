namespace Fakesturant.Web.Models
{
    public class UserDto
    {
        // IDs in Identity are Guids so it must be a string here
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
