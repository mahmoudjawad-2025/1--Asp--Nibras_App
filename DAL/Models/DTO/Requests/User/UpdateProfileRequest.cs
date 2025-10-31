

namespace DAL.Models.DTO.Requests.User
{
    public class UpdateProfileRequest
    {
        public string FullName { get; set; }
        public string UserName { get; set; } // must be unique
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
    }
}
