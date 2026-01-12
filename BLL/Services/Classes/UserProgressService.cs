using B_L_L.Services.Classes;
using B_L_L.Services.Interfaces;
using BLL.Services.Classes;
using BLL.Services.Interfaces;
using D_A_L.Repositories.Classes;
using D_A_L.Repositories.Interfaces;
using DAL.Models.DTO.Requests.UserProgress;
using DAL.Models.DTO.Responses;
using DAL.Models.Entities;
using DAL.Models.Enums;
using DAL.Repositories.Interfaces;
using DAL.Utils;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace BLL.Services.Classes
{
    public class UserProgressService : GenericService<UserProgress, UserProgressResponse, UserProgress>, IUserProgressService
    {
        private readonly IUserProgressRepository _repository;
        private readonly UserManager<User> _userManager;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IThikrItemRepository _thikrItemRepository;
        private readonly IHadithRepository _hadithRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUtilsService _utilsService;


        //-------------------------------------------------------------------------- constructer
        public UserProgressService(
            IUserProgressRepository repository,
            UserManager<User> userManager,
            IHttpContextAccessor contextAccessor,
            IThikrItemRepository thikrItemRepository,
            IHadithRepository hadithRepository,
            ICategoryRepository categoryRepository,
            IUtilsService utilsService
        ) : base( repository )
        {
            _repository = repository;
            _userManager = userManager;
            _contextAccessor = contextAccessor;
            _thikrItemRepository = thikrItemRepository;
            _hadithRepository = hadithRepository;
            _categoryRepository = categoryRepository;
            _utilsService = utilsService;
        }



        //-------------------------------------------------------------------------- AddOrIncrementAsync
        public async Task<UserProgressResponse> AddOrIncrementAsync(ProgressCreateRequest request)
        {
            var userId = await _utilsService.GetCurrentUserIdAsync(_userManager,_contextAccessor);

            // 1- Validate related item existence before proceeding
            bool exists = request.Type switch
            {
                ProgressType.Thikr => await _thikrItemRepository.ExistsAsync(request.RelatedItemId),
                ProgressType.Hadith => await _hadithRepository.ExistsAsync(request.RelatedItemId),
                ProgressType.Category => await _categoryRepository.ExistsAsync(request.RelatedItemId),
                _ => false
            };

            if (!exists)
                throw new Exception("Related item not found");


            // 2- Proceed with normal logic
            var existing = await _repository.GetByUserAndItemAsync(userId, request.Type, request.RelatedItemId);
            if (existing != null)
            {
                existing.Count += request.Count;
                existing.LastUpdated = DateTime.UtcNow;
                _repository.UpdateAsync(existing);
                return existing.Adapt<UserProgressResponse>();
            }

            var progress = new UserProgress
            {
                UserId = userId,
                Type = request.Type,
                RelatedItemId = request.RelatedItemId,
                Count = request.Count
            };

            _repository.CreateAsync(progress);
            return progress.Adapt<UserProgressResponse>();
        }


        //-------------------------------------------------------------------------- GetUserProgressAsync
        public async Task<IEnumerable<UserProgressResponse>> GetUserProgressAsync()
        {
            var userId = await _utilsService.GetCurrentUserIdAsync(_userManager, _contextAccessor);
            var list = await _repository.GetByUserIdAsync(userId);
            return list.Adapt<IEnumerable<UserProgressResponse>>();
        }
    }

}
