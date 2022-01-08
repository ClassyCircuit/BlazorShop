using Microsoft.AspNetCore.Http;

namespace BlazorShop.Data.DataManagers
{
    public class FileManager
    {
        private readonly string _imageDirectoryPath;

        public FileManager(string imageDirectoryPath)
        {
            _imageDirectoryPath = imageDirectoryPath;
        }

        public async Task<string> SaveFile(IFormFile file, string name)
        {
            string relativePath = Path.Combine("images", "products", name);
            string fullPath = Path.Combine(_imageDirectoryPath, relativePath);
            using (Stream fileStream = new FileStream(fullPath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            return relativePath;
        }
    }
}
