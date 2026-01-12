

namespace DAL.Utils
{
    using System.Text.RegularExpressions;

    public static class ArabicHelper
    {
        // removes diacritics, maps common variants to base letters, collapses whitespace
        public static string NormalizeArabic(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return string.Empty;

            input = input.Trim();

            // map some letters to base forms
            input = input
                .Replace('آ', 'ا')
                .Replace('أ', 'ا')
                .Replace('إ', 'ا')
                .Replace('ٱ', 'ا')   // small alif
                .Replace('ى', 'ي')
                .Replace('ؤ', 'و')
                .Replace('ئ', 'ي')
                .Replace('ٮ', 'ن'); // optional if present

            // remove tatweel (kashida) U+0640
            input = input.Replace("\u0640", string.Empty);

            // remove Qur'anic special marks & Arabic diacritics ranges
            // common diacritics: U+064B - U+065F, plus Quranic marks U+06D6 - U+06ED
            input = Regex.Replace(input, @"[\u0610-\u061A\u064B-\u065F\u06D6-\u06ED\u06E9\u06EE\u06EF\u06E6-\u06ED\u0670\u06EA\u06EB\u06EC\u06ED]", string.Empty);

            // remove other strange marks like small letters, etc.
            input = Regex.Replace(input, @"[^\S\r\n]+", " "); // collapse whitespace
            return input.Trim();
        }
    }

}
