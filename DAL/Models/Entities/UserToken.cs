namespace DAL.Models.Entities
{
    public class UserToken
    {
        public int Id { get; set; }
        public string UserId { get; set; } = string.Empty;
        public string Token { get; set; } = string.Empty;
        public DateTime ExpiryDate { get; set; }
        public bool IsRevoked { get; set; }

        public User User { get; set; } = null!;
    }
}
