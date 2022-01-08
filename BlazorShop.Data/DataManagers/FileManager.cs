using Microsoft.AspNetCore.Http;

namespace BlazorShop.Data.DataManagers
{
    public class FileManager
    {
        private readonly DataConfig _dataConfig;

        public FileManager(DataConfig dataConfig)
        {
            _dataConfig = dataConfig;
        }

        public async Task<string> SaveFile(IFormFile file, string name)
        {
            string relativePath = Path.Combine("images", "products", name);
            string fullPath = Path.Combine(_dataConfig.ImageDirectoryPath, relativePath);
            using (Stream fileStream = new FileStream(fullPath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            return relativePath;
        }
    }
}
