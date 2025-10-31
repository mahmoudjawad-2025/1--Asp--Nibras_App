using DAL.Models.Entities;
using DAL.Models.Entities.QuranEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.DTO.Requests.Quran
{
    public class AyahRequest : BaseModel
    {
        public int SurahNumber { get; set; }
        public int NumberInSurah { get; set; }
        public int GlobalNumber { get; set; }
        [Column(TypeName = "NVARCHAR(MAX)")]
        public string Text { get; set; }
        [Column(TypeName = "NVARCHAR(MAX)")]
        public string NormalizedText { get; set; }
        public int Juz { get; set; }
        public int Page { get; set; }

        public int SurahId { get; set; }
        public Surah Surah { get; set; }
    }
}
