using BLL.Services.Interfaces; using Microsoft.AspNetCore.Authorization;
using DAL.Models.DTO.Requests.Thikr;
using DAL.Models.DTO.Responses.Thikr;
using DAL.Models.Entities.Thikr;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace PL.Areas.Student.Thikr
{
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Area("Student")]
    [Authorize(Roles = "Student")]
    public class ThikrItemController : ControllerBase
    {
        private readonly IThikrItemService _service;

        public ThikrItemController(IThikrItemService itemService)
        {
            _service = itemService;
        }


        //-------------------------------------------------------------------------- GetAll
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllAsync(c => new ThikrItemResponse
            {
                Id = c.Id,
                Text = c.Text,
                Count = c.Count,
                Description = c.Description,
                Reference = c.Reference,
                ThikrCategoryId = c.ThikrCategoryId
            });
            return Ok(result);
        }


        //-------------------------------------------------------------------------- GetById
        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id, c => new ThikrItemResponse
            {
                Id = c.Id,
                Text = c.Text,
                Count = c.Count,
                Description = c.Description,
                Reference = c.Reference,
                ThikrCategoryId = c.ThikrCategoryId
            });
            return result == null ? NotFound() : Ok(result);
        }


        //-------------------------------------------------------------------------- GetByCategoryId
        [HttpGet("GetByCategoryId/{categoryId}")]
        public async Task<IActionResult> GetByCategoryId(int categoryId)
        {
            var result = await _service.GetByCategoryId(categoryId);
            return Ok(result);
        }


        //-------------------------------------------------------------------------- Search
        [HttpGet("Search")]
        public async Task<IActionResult> SearchGeneric([FromQuery] string query)
        {
            var results = await _service.SearchAsync(
                query,
                new Expression<Func<ThikrItem, string>>[]
                {
                    x => x.NormalizedText,
                    //x => x.EnglishTitle
                },
                limit: 20
            );

            return Ok(results);
        }


        //-------------------------------------------------------------------------- GetByCount
        [HttpGet("GetByCount")]
        public async Task<IActionResult> GetByCount([FromQuery] int minCount, [FromQuery] int maxCount)
        {
            var result = await _service.GetByCount(minCount, maxCount);
            return Ok(result);
        }

    }

}
