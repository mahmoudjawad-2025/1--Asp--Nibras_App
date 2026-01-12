using BLL.Services.Interfaces;
using DAL.Models.DTO.Requests.Auth;
using DAL.Models.DTO.Requests.User;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace PL.Areas.Admin
{
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IHttpContextAccessor _contextAccessor;

        public UserController(IUserService userService, IHttpContextAccessor contextAccessor)
        {
            _userService = userService;
            _contextAccessor = contextAccessor;
        }


        //-------------------------------------------------------------------------- GetAllUsers
        [HttpGet("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userService.GetAllAsync();
            return Ok(users);
        }


        //-------------------------------------------------------------------------- GetUserById
        [HttpGet("GetUserById/{id}")]
        public async Task<IActionResult> GetUserById([FromRoute] string id)
        {
            var user = await _userService.GetByIdAsync(id);
            return Ok(user);
        }


        //-------------------------------------------------------------------------- BlockUser
        [HttpPatch("BlockUser/{userId}")]
        public async Task<IActionResult> BlockUser([FromRoute] string userId, [FromBody] int days)
        {
            var result = await _userService.BlockUserAsync(userId, days);
            return Ok(result);
        }


        //-------------------------------------------------------------------------- UnBlockUser
        [HttpPatch("UnBlockUser/{userId}")]
        public async Task<IActionResult> UnBlockUser([FromRoute] string userId)
        {
            var result = await _userService.UnBlockUserAsync(userId);
            return Ok(result);
        }


        //-------------------------------------------------------------------------- IsBlockedUser
        [HttpPatch("IsBlockedUser/{userId}")]
        public async Task<IActionResult> IsBlockedUser([FromRoute] string userId)
        {
            var result = await _userService.IsBlockedAsync(userId);
            return Ok(result);
        }


        //-------------------------------------------------------------------------- ChangeRole
        [HttpPatch("ChangeRole/{userId}")]
        public async Task<IActionResult> ChangeRole([FromRoute] string userId, [FromBody] ChangeRoleRequest request)
        {
            var result = await _userService.ChangeUserRoleAsync(userId, request.RoleName);
            return Ok(new { message = "role changed successfully" });
        }


        //-------------------------------------------------------------------------- 
        private string GetUserId() =>
        _contextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value
        ?? throw new Exception("User not authenticated");


        //-------------------------------------------------------------------------- GetMyProfile
        [HttpGet("GetMyProfile")]
        public async Task<IActionResult> GetMyProfile()
        {
            var userId = GetUserId();
            var result = await _userService.GetProfileAsync(userId);
            return Ok(result);
        }


        //-------------------------------------------------------------------------- UpdateMyProfile
        [HttpPut("UpdateMyProfile")]
        public async Task<IActionResult> UpdateMyProfile([FromBody] UpdateProfileRequest request)
        {
            var userId = GetUserId();
            var result = await _userService.UpdateProfileAsync(userId, request);
            return Ok(result);
        }


        //-------------------------------------------------------------------------- ChangePassword
        [HttpPut("ChangePassword")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordRequest request)
        {
            var userId = GetUserId();
            await _userService.ChangePasswordAsync(userId, request);
            return Ok("Password changed successfully");
        }


        //-------------------------------------------------------------------------- ChangeEmail
        [HttpPut("ChangeEmail")]
        public async Task<IActionResult> ChangeEmail([FromBody] ChangeEmailRequest request)
        {
            var userId = GetUserId();
            await _userService.ChangeEmailAsync(userId, request, Request);
            return Ok("Confirmation email sent");
        }


        //-------------------------------------------------------------------------- ConfirmNewEmail
        [AllowAnonymous]
        [HttpGet("ConfirmNewEmail")]
        public async Task<IActionResult> ConfirmNewEmail([FromQuery] string userId, [FromQuery] string token, [FromQuery] string newEmail)
        {
            var result = await _userService.ConfirmNewEmailAsync(userId, token, newEmail);
            return Ok(result);
        }
    }
}
