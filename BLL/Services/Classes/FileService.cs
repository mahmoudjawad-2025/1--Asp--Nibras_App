using B_L_L.Services.Interfaces;
using DAL.Models.Enums;
using DAL.Utils;
using Microsoft.AspNetCore.Http;

namespace B_L_L.Services.Classes
{
    public class FileService : IFileService
    {
        private readonly IUtilsService _utilsService;

        public FileService(IUtilsService utilsService)
        {
            _utilsService = utilsService;
        }

        //-------------------------------------------------------------------------- UploadAsync
        public async Task<string> UploadAsync(IFormFile file, FilesTypes folderType)
        {
            if (file == null || file.Length == 0)
                throw new Exception("Empty file");

            _utilsService.ValidateFileType(file, folderType);

            var extension = Path.GetExtension(file.FileName);
            var folderName = _utilsService.GetFolderName(folderType);
            var folder = Path.Combine("wwwroot", folderName);

            Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), folder));

            var fileName = $"{Guid.NewGuid()}{extension}";
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), folder, fileName);

            using (var stream = File.Create(filePath))
                await file.CopyToAsync(stream);

            return fileName;
        }


        //-------------------------------------------------------------------------- UploadManyAsync
        public async Task<List<string>> UploadManyAsync(List<IFormFile> files, FilesTypes folderType)
        {
            if (files == null || files.Count == 0)
                throw new Exception("No files provided");

            var uploadedFileNames = new List<string>();

            var folderName = _utilsService.GetFolderName(folderType);
            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName);

            Directory.CreateDirectory(folderPath);

            foreach (var file in files)
            {
                if (file == null || file.Length == 0)
                    continue;

                _utilsService.ValidateFileType(file, folderType);

                var extension = Path.GetExtension(file.FileName);
                var fileName = $"{Guid.NewGuid()}{extension}";
                var filePath = Path.Combine(folderPath, fileName);

                using (var stream = File.Create(filePath))
                    await file.CopyToAsync(stream);

                uploadedFileNames.Add(fileName);
            }

            if (uploadedFileNames.Count == 0)
                throw new Exception("No valid files uploaded");

            return uploadedFileNames;
        }


        //-------------------------------------------------------------------------- ReplaceFileAsync
        public async Task<string> ReplaceFileAsync(IFormFile newFile, string? oldPath, FilesTypes folderType)
        {
            if (!string.IsNullOrEmpty(oldPath))
                await DeleteAsync(oldPath, folderType);

            return await UploadAsync(newFile, folderType);
        }

        //-------------------------------------------------------------------------- ReplaceManyAsync
        public async Task<List<string>> ReplaceManyAsync(List<IFormFile> newFiles, List<string>? oldPaths, FilesTypes folderType)
        {
            if (oldPaths != null && oldPaths.Any())
                await DeleteManyAsync(oldPaths, folderType);

            return await UploadManyAsync(newFiles, folderType);
        }

        //-------------------------------------------------------------------------- DeleteAsync
        public async Task DeleteAsync(string fileName, FilesTypes folderType)
        {
            var path = Path.Combine(_utilsService.GetFolderPath(folderType), fileName);
            if (File.Exists(path))
                await Task.Run(() => File.Delete(path));
        }

        //-------------------------------------------------------------------------- DeleteManyAsync
        public async Task DeleteManyAsync(List<string> fileNames, FilesTypes folderType)
        {
            if (fileNames == null || fileNames.Count == 0)
                return;

            foreach (var file in fileNames)
                await DeleteAsync(file, folderType);
        }

    }
}
