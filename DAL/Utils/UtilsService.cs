using DAL.Models.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL.Utils
{
    public class UtilsService : IUtilsService
    {

        private readonly IHttpContextAccessor _httpContextAccessor;

        public UtilsService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        //-------------------------------------------------------------------------- GetFolderName
        public string GetFolderName(FilesTypes type)
        {
            return type switch
            {
                FilesTypes.Image => "images",
                FilesTypes.Video => "videos",
                FilesTypes.Audio => "audio",
                FilesTypes.Pdf => "pdfs",
                _ => "uploads"
            };
        }


        //-------------------------------------------------------------------------- GetFolderPath
        public string GetFolderPath(FilesTypes folderType)
        {
            var folderName = GetFolderName(folderType);
            return Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName);
        }


        //-------------------------------------------------------------------------- GetFileUrl
        public string? GetFileUrl(FilesTypes type, string fileName, HttpRequest? request)
        {
            if (string.IsNullOrEmpty(fileName) || request == null)
                return null;

            var folder = GetFolderName(type);
            return $"{request.Scheme}://{request.Host}/{folder}/{fileName}";
        }


        //-------------------------------------------------------------------------- ValidateFileType
        private static readonly Dictionary<FilesTypes, string[]> _allowedExtensions = new()
        {
            { FilesTypes.Image, new[] { ".jpg", ".jpeg", ".png", ".gif", ".webp" } },
            { FilesTypes.Video, new[] { ".mp4", ".mov", ".avi", ".mkv" } },
            { FilesTypes.Audio, new[] { ".mp3", ".wav", ".ogg", ".aac" } },
            { FilesTypes.Pdf, new[] { ".pdf" } }
        };

        private static readonly Dictionary<FilesTypes, string[]> _allowedMimeTypes = new()
        {
            { FilesTypes.Image, new[] { "image/jpeg", "image/png", "image/gif", "image/webp" } },
            { FilesTypes.Video, new[] { "video/mp4", "video/quicktime", "video/x-msvideo", "video/x-matroska" } },
            { FilesTypes.Audio, new[] { "audio/mpeg", "audio/wav", "audio/ogg", "audio/aac" } },
            { FilesTypes.Pdf, new[] { "application/pdf" } }
        };

        public void ValidateFileType(IFormFile file, FilesTypes declaredType)
        {
            var ext = Path.GetExtension(file.FileName).ToLowerInvariant();
            var mime = file.ContentType.ToLowerInvariant();

            if (!_allowedExtensions.TryGetValue(declaredType, out var exts) || !_allowedMimeTypes.TryGetValue(declaredType, out var mimes))
                throw new Exception($"Unsupported file type: {declaredType}");

            if (!exts.Contains(ext) || !mimes.Contains(mime))
                throw new Exception($"Invalid file type. Expected {declaredType} but got {ext}/{mime}");
        }

        //-------------------------------------------------------------------------- GetCurrentUserIdAsync
        public async Task<string> GetCurrentUserIdAsync<TUser>(
            UserManager<TUser> userManager,
            IHttpContextAccessor httpContextAccessor)
            where TUser : IdentityUser
        {
            var httpContext = httpContextAccessor.HttpContext;
            if (httpContext == null)
                throw new InvalidOperationException("HTTP context is not available.");

            var user = await userManager.GetUserAsync(httpContext.User);
            if (user == null)
                throw new UnauthorizedAccessException("User is not authenticated.");

            return user.Id;
        }


        //-------------------------------------------------------------------------- NormalizeArabic
        public string NormalizeArabic(string input)
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


        //-------------------------------------------------------------------------- GetPropertyName
        public string GetPropertyName<T>(Expression<Func<T, string>> expression)
        {
            if (expression.Body is MemberExpression member)
                return member.Member.Name;
            if (expression.Body is UnaryExpression unary && unary.Operand is MemberExpression memberExpr)
                return memberExpr.Member.Name;

            throw new ArgumentException("Invalid property expression");
        }


        //-------------------------------------------------------------------------- OrElse
        public Expression<Func<T, bool>> OrElse<T>(Expression<Func<T, bool>> expr1, Expression<Func<T, bool>> expr2)
        {
            var parameter = Expression.Parameter(typeof(T));
            var body = Expression.OrElse(
                Expression.Invoke(expr1, parameter),
                Expression.Invoke(expr2, parameter));
            return Expression.Lambda<Func<T, bool>>(body, parameter);
        }
    }
}
