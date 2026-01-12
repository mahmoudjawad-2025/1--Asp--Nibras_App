using BLL.Services.Classes;
using BLL.Services.Interfaces;
using DAL.Models.DTO.Requests.Thikr;
using DAL.Models.DTO.Responses.Thikr;
using DAL.Models.Entities.QuranEntities;
using DAL.Models.Entities.Thikr;
using DAL.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace PL.Areas.Admin.Thikr
{
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class ThikrCategoryController : ControllerBase
    {
        private readonly IThikrCategoryService _service;
        private readonly IUtilsService _utilsService;

        public ThikrCategoryController(IThikrCategoryService categoryService, IUtilsService utilsService)
        {
            _service = categoryService;
            _utilsService = utilsService;
        }


        //-------------------------------------------------------------------------- GetAudioUrls
        [HttpGet("GetAudioUrls")]
        public async Task<IActionResult> GetAudioUrls()
        {
            var result = await _service.GetAllCategoriesAudiosAsync();
            return Ok(result);
        }


        //-------------------------------------------------------------------------- GetAll
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllAsync(c => new ThikrCategoryResponse
            {
                Id = c.Id,
                Title = c.Title,
                //AudioUrl = $"{Request.Scheme}://{Request.Host}/audio/thikr/{c.AudioUrl}",
                //AudioUrl = _utilsService.WwwrootUrl + $"audio/thikr/{c.AudioUrl}",
                ThikrItemsIds = c.ThikrItems.Select(q => q.Id).ToList()
            });
            return Ok(result);
        }


        //-------------------------------------------------------------------------- GetById
        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id, c => new ThikrCategoryResponse
            {
                Id = c.Id,
                Title = c.Title,
                //AudioUrl = urlHelperService.WwwrootUrl + $"audio/thikr/{c.AudioUrl}",
                ThikrItemsIds = c.ThikrItems.Select(q => q.Id).ToList()
            });
            return result == null ? NotFound() : Ok(result);
        }


        //-------------------------------------------------------------------------- Search
        [HttpGet("Search")]
        public async Task<IActionResult> SearchGeneric([FromQuery] string query)
        {
            var results = await _service.SearchAsync(
                query,
                new Expression<Func<ThikrCategory, string>>[]
                {
                    x => x.NormalizedText,
                    //x => x.EnglishTitle
                },
                limit: 20
            );

            return Ok(results);
        }


        //-------------------------------------------------------------------------- Create
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] ThikrCategoryRequest request)
        {
            try
            {
                var result = await _service.CreateAsync(request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        //-------------------------------------------------------------------------- Update
        [HttpPut("Update/{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] ThikrCategoryRequest request)
        {
            try
            {
                var result = await _service.UpdateAsync(id, request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        //-------------------------------------------------------------------------- Delete
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var deleted = await _service.DeleteAsync(id);
            return deleted > 0 ? Ok(new { message = "Done Successfuly!" }) : NotFound(new { message = "Item not found" });
        }


        //-------------------------------------------------------------------------- ToggleStatus
        [HttpPatch("ToggleStatus/{id}")]
        public async Task<IActionResult> ToggleStatus([FromRoute] int id)
        {
            var updated = await _service.ToggleStatusAsync(id);
            return updated ? Ok(new { message = "Done Successfuly!" }) : NotFound(new { message = "Item not found" });
        }
    }

}
