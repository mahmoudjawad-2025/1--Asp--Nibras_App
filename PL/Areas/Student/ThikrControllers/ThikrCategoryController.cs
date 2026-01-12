using BLL.Services.Interfaces; 
using Microsoft.AspNetCore.Authorization;
using DAL.Models.DTO.Requests.Thikr;
using DAL.Models.DTO.Responses.Thikr;
using DAL.Models.Entities.Thikr;
using DAL.Utils;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace PL.Areas.Student.Thikr
{
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Area("Student")]
    [Authorize(Roles = "Student")]
    public class ThikrCategoryController : ControllerBase
    {
        private readonly IThikrCategoryService _service;
        private readonly IUtilsService _utilsService;

        public ThikrCategoryController(IThikrCategoryService categoryService, IUtilsService utilsService)
        {
            _service = categoryService;
            _utilsService = utilsService;
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

    }

}
