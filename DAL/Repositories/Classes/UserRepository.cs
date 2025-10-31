using D_A_L.Repositories.Classes;
using DAL.Models.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Classes
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<User> _userManager;

        public UserRepository(UserManager<User> userManager)
        {
            _userManager = userManager;
        }


        //-------------------------------------------------------------------------- GetAllAsync
        public async Task<List<User>> GetAllAsync()
        {
            return await _userManager.Users.Include(c => c.UserProgresses).ToListAsync();
        }


        //-------------------------------------------------------------------------- GetByIdAsync
        public async Task<User> GetByIdAsync(string userId)
        {
            return await _userManager.FindByIdAsync(userId);
        }


        //-------------------------------------------------------------------------- IsBlockedAsync
        public async Task<bool> IsBlockedAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user is null) return false;
            return user.LockoutEnd.HasValue && user.LockoutEnd > DateTime.UtcNow;
        }


        //-------------------------------------------------------------------------- UnBlockUserAsync
        public async Task<bool> UnBlockUserAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user is null) return false;
            user.LockoutEnd = null;
            var result = await _userManager.UpdateAsync(user);
            return result.Succeeded;
        }


        //-------------------------------------------------------------------------- BlockUserAsync
        public async Task<bool> BlockUserAsync(string userId, int days)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user is null) return false;
            user.LockoutEnd = DateTime.UtcNow.AddDays(days);
            var result = await _userManager.UpdateAsync(user);
            return result.Succeeded;
        }


        //-------------------------------------------------------------------------- ChangeUserRoleAsync
        public async Task<bool> ChangeUserRoleAsync(string userId, string roleName)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user is null) return false;
            var currentRoles = await _userManager.GetRolesAsync(user);
            var removeResult = await _userManager.RemoveFromRolesAsync(user, currentRoles);
            var addResult = await _userManager.AddToRoleAsync(user, roleName);
            return removeResult.Succeeded;
        }


        //-------------------------------------------------------------------------- UpdateAsync
        public async Task UpdateAsync(User user)
        {
            await _userManager.UpdateAsync(user);
        }
    }
}
