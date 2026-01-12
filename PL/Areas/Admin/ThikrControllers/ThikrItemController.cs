using BLL.Services.Interfaces;
using DAL.Models.DTO.Requests.Thikr;
using DAL.Models.DTO.Responses.Thikr;
using DAL.Models.Entities.Thikr;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stripe;
using System.Linq.Expressions;

namespace PL.Areas.Admin.Thikr
{
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
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


        //-------------------------------------------------------------------------- Create
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] ThikrItemRequest request)
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
        public async Task<IActionResult> Update(int id, [FromBody] ThikrItemRequest request)
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
