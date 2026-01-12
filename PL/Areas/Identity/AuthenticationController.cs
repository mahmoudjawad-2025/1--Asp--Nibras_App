using B_L_L.Services.Interfaces;
using DAL.Models.DTO.Requests.Auth;
using DAL.Models.DTO.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace P_L.Areas.Identity
{
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Area("Identity")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authernticationService)
        {
            _authenticationService = authernticationService;
        }


        //-------------------------------------------------------------------------- RefreshToken
        [HttpPost("Refresh")]
        public async Task<ActionResult<UserDto>> RefreshToken([FromBody] RefreshTokenRequest request)
        {
            var result = await _authenticationService.RefreshTokenAsync(request);
            return Ok(result);
        }


        //-------------------------------------------------------------------------- Register
        [HttpPost("Register")]
        public async Task<ActionResult<UserDto>> Register(RegisterRequest registerRequest)
        {
            var result = await _authenticationService.RegisterAsync(registerRequest, Request);
            return Ok(result);
        }


        //-------------------------------------------------------------------------- Login
        [HttpPost("Login")]
        public async Task<ActionResult<UserDto>> Login(LoginRequest loginRequest)
        {
            var result = await _authenticationService.LoginAsync(loginRequest);
            return Ok(result);
        }


        //-------------------------------------------------------------------------- Logout
        //}
        [HttpPost("Logout")]
        public async Task<IActionResult> Logout()
        {
            var accessToken = HttpContext.Request.Headers["Authorization"].ToString().Replace("Bearer ", "").Trim();

            if (string.IsNullOrEmpty(accessToken))
                return BadRequest("Missing access token");

            await _authenticationService.LogoutAsync(accessToken); 
            return Ok("Logged out");
        }



        //-------------------------------------------------------------------------- ConfirmEmail
        [HttpGet("ConfirmEmail")]
        public async Task<ActionResult<string>> ConfirmEmail([FromQuery] string token, [FromQuery] string userId)
        {
            var result = await _authenticationService.ConfirmEmail(token, userId);
            return Ok(result);
        }


        //-------------------------------------------------------------------------- ForgotPassword
        [HttpPost("ForgotPassword")]
        public async Task<ActionResult<string>> ForgotPassword([FromBody] ForgotPasswordRequest request)
        {
            var result = await _authenticationService.ForgotPassword(request);
            return Ok(result);
        }


        //-------------------------------------------------------------------------- ResetPassword
        [HttpPost("ResetPassword")]
        public async Task<ActionResult<string>> ResetPassword([FromBody] ResetPasswordRequest request)
        {
            var result = await _authenticationService.ResetPassword(request);
            return Ok(result);
        }
    }
}
