
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models.Entities.QuranEntities
{
    public class Surah : BaseModel
    {
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
