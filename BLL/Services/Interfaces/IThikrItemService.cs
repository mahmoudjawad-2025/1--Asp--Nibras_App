using B_L_L.Services.Interfaces;
using DAL.Models.DTO.Requests.Thikr;
using DAL.Models.DTO.Responses.Thikr;
using DAL.Models.Entities.Thikr;

namespace BLL.Services.Interfaces
{
    public interface IThikrItemService : IGenericService<ThikrItemRequest, ThikrItemResponse, ThikrItem>
    {
        Task<List<ThikrItemResponse>> GetByCategoryId(int categoryId);
        Task<List<ThikrItemResponse>> GetByCount(int minCount, int maxCount);
    }
}
