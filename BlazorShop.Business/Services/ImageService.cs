using BlazorShop.Business.Exceptions;
using BlazorShop.Data.DataManagers;
using Microsoft.AspNetCore.Http;

namespace BlazorShop.Business.Services
{
    public class ImageService
    {
        private readonly FileManager _fileManager;

        public ImageService(FileManager fileManager)
        {
            _fileManager = fileManager;
        }

        public async Task<string> SaveImage(IFormFile image)
        {
            if (image.Length <= 0)
            {
                throw new InvalidFileException();
            }

            var fileName = $"{Guid.NewGuid()}.jpg";
            var fullFilePath = await _fileManager.SaveFile(image, fileName);

            return fullFilePath;
        }
    }
}
