using BlazorShop.Business.Exceptions;
using BlazorShop.Data.DataManagers;
using Microsoft.AspNetCore.Components.Forms;

namespace BlazorShop.Business.Services
{
	public class ImageService
	{
		private readonly FileManager _fileManager;

		public ImageService(FileManager fileManager)
		{
			_fileManager = fileManager;
		}

		public async Task<string> SaveImage(IBrowserFile image)
		{
			if (image.Size <= 0)
			{
				throw new InvalidFileException();
			}

			var fileName = $"{Guid.NewGuid()}.jpg";
			var fullFilePath = await _fileManager.SaveFile(image, fileName);

			return fullFilePath;
		}
	}
}
