using B_L_L.Services.Interfaces;
using DAL.Models.DTO.Requests.Thikr;
using DAL.Models.DTO.Responses.Thikr;
using DAL.Models.Entities.Thikr;

namespace BLL.Services.Interfaces
{
    public interface IThikrCategoryService : IGenericService<ThikrCategoryRequest, ThikrCategoryResponse, ThikrCategory>
    {
        Task<List<string>> GetAllCategoriesAudiosAsync();
        Task<List<ThikrCategoryResponse>> SearchAllWithItems(string query);
    }
}
