using DAL.Models.Entities.QuranEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models.DTO.Requests.Quran
{
    public class SurahRequest
    {
        public int Id { get; set; }
        public int Number { get; set; }
        [Column(TypeName = "NVARCHAR(MAX)")]
        public string Name { get; set; }
        [Column(TypeName = "NVARCHAR(MAX)")]
        public string EnglishName { get; set; }
        public string EnglishNameTranslation { get; set; }
        public string RevelationPlace { get; set; }
        public int AyahCount { get; set; }

        public IList<Ayah> Ayahs { get; set; } = new List<Ayah>();
    }
}
