using BLL.Services.Interfaces;
using DAL.Models.DTO.Requests.UserProgress;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PL.Areas.Student
{
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Area("Student")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Authorize(Roles = "Student")]
    public class UserProgressController : ControllerBase
    {
        private readonly IUserProgressService _service;

        public UserProgressController(IUserProgressService service)
        {
            _service = service;
        }


        //-------------------------------------------------------------------------- add 
        [HttpPost("add")]
        public async Task<IActionResult> AddProgress([FromBody] ProgressCreateRequest request)
        {
            var result = await _service.AddOrIncrementAsync(request);
            return Ok(result);
        }


        //-------------------------------------------------------------------------- get
        [HttpGet("me")]
        public async Task<IActionResult> GetMyProgress()
        {
            var result = await _service.GetUserProgressAsync();
            return Ok(result);
        }
    }

}
