using BLL.Services.Interfaces;
using DAL.Models.DTO.Requests.Auth;
using DAL.Models.DTO.Requests.User;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace PL.Areas.Student
{
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Area("Student")]
    [Authorize(Roles = "Student")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IHttpContextAccessor _contextAccessor;

        public UserController(IUserService userService, IHttpContextAccessor contextAccessor)
        {
            _userService = userService;
            _contextAccessor = contextAccessor;
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
