
using Microsoft.AspNetCore.Http;

namespace DAL.Models.DTO.Requests
{
    public class CategoryRequest
    {
        public string Name { get; set; }
        //img
        public IFormFile MainImage { get; set; }
    }
}
