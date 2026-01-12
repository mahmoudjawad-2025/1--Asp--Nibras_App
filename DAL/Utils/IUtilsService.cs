using DAL.Models.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Utils
{
    public interface IUtilsService
    {
        Task<string> GetCurrentUserIdAsync<TUser>(
            UserManager<TUser> userManager,
            IHttpContextAccessor httpContextAccessor)
            where TUser : IdentityUser;

        string GetFolderName(FilesTypes type);
        string GetFolderPath(FilesTypes folderType);
        void ValidateFileType(IFormFile file, FilesTypes declaredType);
        string? GetFileUrl(FilesTypes type, string fileName, HttpRequest? request);
        string NormalizeArabic(string input);
        string GetPropertyName<T>(Expression<Func<T, string>> expression);
        Expression<Func<T, bool>> OrElse<T>(Expression<Func<T, bool>> expr1, Expression<Func<T, bool>> expr2);
    }
}
