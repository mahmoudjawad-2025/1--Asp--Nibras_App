
using Microsoft.AspNetCore.Identity;

namespace DAL.Models.Entities
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
        public string? ResetPasswordCode { get; set; }
        public DateTime? ResetPasswordCodeExpiry { get; set; }
        public List<UserProgress> UserProgresses { get; set; }

        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiry { get; set; }
        public bool IsRefreshTokenRevoked { get; set; }

    }
}
