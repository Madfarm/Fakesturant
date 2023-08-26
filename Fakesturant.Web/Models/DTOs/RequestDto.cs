namespace Fakesturant.Web.Models.DTOs
{
    public class RequestDto
    {
        public string ApiType { get; set; } = "GET";
        public string Url { get; set; }
        public object Data { get; set; }
        public string AccessTables { get; set; }
    }
}
