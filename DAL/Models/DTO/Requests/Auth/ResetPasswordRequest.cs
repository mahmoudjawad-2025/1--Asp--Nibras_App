
namespace DAL.Models.DTO.Requests.Auth
{
    public class ResetPasswordRequest
    {
        public string NewPassword { get; set; }
        public string Email { get; set; }
        public string Code { get; set; }
    }
}
