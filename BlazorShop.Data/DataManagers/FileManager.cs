using Microsoft.AspNetCore.Components.Forms;

namespace BlazorShop.Data.DataManagers
{
	public class FileManager
	{
		private readonly DataConfig _dataConfig;

		public FileManager(DataConfig dataConfig)
		{
			_dataConfig = dataConfig;
		}

		public async Task<string> SaveFile(IBrowserFile file, string name)
		{
			string relativePath = Path.Combine("images", "products", name);
			string fullPath = Path.Combine(_dataConfig.ImageDirectoryPath, relativePath);
			using (Stream fileStream = new FileStream(fullPath, FileMode.Create))
			{
				await file.OpenReadStream().CopyToAsync(fileStream);
			}

			return relativePath;
		}
	}
}
