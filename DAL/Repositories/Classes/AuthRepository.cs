using D_A_L.Data_Base;
using DAL.Models.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Classes
{
    public class AuthRepository : IAuthRepository
    {
        private readonly ApplicationDbContext _context;

        public AuthRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddUserTokenAsync(UserToken token)
        {
            await _context.UserTokens.AddAsync(token);
        }

        public async Task<UserToken?> GetTokenAsync(string token)
        {
            return await _context.UserTokens
                .Include(t => t.User)
                .FirstOrDefaultAsync(t => t.Token == token);
        }

        public async Task RevokeTokenAsync(string token)
        {
            var tokenEntity = await GetTokenAsync(token);
            if (tokenEntity != null)
            {
                tokenEntity.IsRevoked = true;
            }
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
