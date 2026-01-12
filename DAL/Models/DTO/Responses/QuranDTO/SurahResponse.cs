

namespace DAL.Models.DTO.Responses.QuranDTO
{
    public class SurahResponse
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public string EnglishName { get; set; }
        public string EnglishNameTranslation { get; set; }
        public string RevelationPlace { get; set; }
        public int AyahCount { get; set; }
        public List<AyahResponse> Ayahs { get; set; }
    }
}
