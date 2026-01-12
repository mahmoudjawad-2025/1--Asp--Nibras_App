

namespace DAL.Models.DTO.Responses
{
    public class UserResponse
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool EmailConfirmed { get; set; }
        public string RoleName { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
        public List<UserProgressResponse> UserProgresses { get; set; }
    }
}
