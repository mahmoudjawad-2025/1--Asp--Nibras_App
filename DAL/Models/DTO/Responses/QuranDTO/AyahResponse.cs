namespace DAL.Models.DTO.Responses.QuranDTO
{
    public class AyahResponse
    {
        public int Id { get; set; }
        public int SurahNumber { get; set; }
        public int NumberInSurah { get; set; }
        public int GlobalNumber { get; set; }
        public string Text { get; set; }
        public string NormalizedText { get; set; }
        public int Juz { get; set; }
        public int Page { get; set; }
    }
}
