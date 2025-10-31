using D_A_L.Data_Base;
using Microsoft.Extensions.Logging;

namespace DAL.Utils
{
    public interface ISeedData
    {
        public Task DataSeedingAsync();
        public Task IdentityDataSeedingAsync();
        Task SeedQuranIfEmptyAsync(ApplicationDbContext db, string quranJsonPath, ILogger logger = null);
        Task SeedHadithIfEmptyAsync(ApplicationDbContext db, string hadithDirPath, ILogger logger = null);
        Task SeedAdhkarIfEmptyAsync(ApplicationDbContext db, string adhkarJsonPath, ILogger logger = null);
    }
}
