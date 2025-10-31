using B_L_L.Services.Classes;
using BLL.Services.Interfaces;
using DAL.Models.DTO.Requests.Thikr;
using DAL.Models.DTO.Responses.Thikr;
using DAL.Models.Entities.Thikr;
using DAL.Repositories.Interfaces;

namespace BLL.Services.Classes
{
    public class ThikrCategoryService : GenericService<ThikrCategoryRequest, ThikrCategoryResponse, ThikrCategory>, IThikrCategoryService
    {
        private readonly IThikrCategoryRepository _repository;

        public ThikrCategoryService(IThikrCategoryRepository repository) : base(repository)
        {
            _repository = repository;
        }


        //-------------------------------------------------------------------------- GetAllCategoriesAudiosAsync
        public async Task<List<string>> GetAllCategoriesAudiosAsync()
        {
            var items = await _repository.GetAllCategoriesAudiosAsync();
            return items;
        }



        //-------------------------------------------------------------------------- SearchAllWithItems
        public async Task<List<ThikrCategoryResponse>> SearchAllWithItems(string query)
        {
            var categories = await _repository.SearchAllWithItemsAsync(query);
            return categories.Select(c => new ThikrCategoryResponse
            {
                Id = c.Id,
                Title = c.Title,
                AudioUrl = c.AudioUrl,
                ThikrItems = c.ThikrItems.Select(i => new ThikrItemResponse
                {
                    Id = i.Id,
                    Text = i.Text,
                    Count = i.Count,
                    Description = i.Description,
                    Reference = i.Reference
                }).ToList()
            }).ToList();
        }
    }
}
