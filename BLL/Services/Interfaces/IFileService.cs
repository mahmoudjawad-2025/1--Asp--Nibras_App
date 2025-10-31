using DAL.Models.Enums;
using Microsoft.AspNetCore.Http;

namespace B_L_L.Services.Interfaces
{
    public interface IFileService 
    {
        Task<string> UploadAsync(IFormFile file, FilesTypes folderType);
        Task<List<string>> UploadManyAsync(List<IFormFile> files, FilesTypes folderType);
        Task<string> ReplaceFileAsync(IFormFile newFile, string? oldPath, FilesTypes folderType);
        Task<List<string>> ReplaceManyAsync(List<IFormFile> newFiles, List<string>? oldPaths, FilesTypes folderType);
        Task DeleteAsync(string fileName, FilesTypes folderType);
        Task DeleteManyAsync(List<string> fileNames, FilesTypes folderType);

    }
}
