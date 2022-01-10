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

		public async Task<string> SaveImages(IBrowserFile[] images)
		{
			var fileName = $"{Guid.NewGuid()}.jpg";
			var fullFilePath = await _fileManager.SaveFiles(image, fileName);

			return fullFilePath;
		}
	}
}
