using B_L_L.Services.Classes;
using BLL.Services.Interfaces;
using DAL.Models.DTO.Requests.Thikr;
using DAL.Models.DTO.Responses.Thikr;
using DAL.Models.Entities.Thikr;
using DAL.Repositories.Interfaces;

namespace BLL.Services.Classes
{
    public class ThikrItemService : GenericService<ThikrItemRequest, ThikrItemResponse, ThikrItem>, IThikrItemService
    {
        private readonly IThikrItemRepository _repository;

        public ThikrItemService(IThikrItemRepository repository) : base(repository)
        {
            _repository = repository;
        }


        //-------------------------------------------------------------------------- GetByCategoryId
        public async Task<List<ThikrItemResponse>> GetByCategoryId(int categoryId)
        {
            var items = await _repository.GetByCategoryIdAsync(categoryId);
            return items.Select(i => new ThikrItemResponse
            {
                Id = i.Id,
                Text = i.Text,
                Count = i.Count,
                Description = i.Description,
                Reference = i.Reference
            }).ToList();
        }



        //-------------------------------------------------------------------------- GetByCount
        public async Task<List<ThikrItemResponse>> GetByCount(int minCount, int maxCount)
        {
            var items = await _repository.GetByCountAsync(minCount, maxCount);
            return items.Select(i => new ThikrItemResponse
            {
                Id = i.Id,
                Text = i.Text,
                Count = i.Count,
                Description = i.Description,
                Reference = i.Reference
            }).ToList();
        }
    }
}
