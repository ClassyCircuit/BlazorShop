using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Web.ViewModels
{
	public class ProductAddModel
	{
		[Required]
		public string Name { get; set; }

		[Required]
		public decimal Price { get; set; }

		[Required]
		public string CategoryId { get; set; }

		public IBrowserFile[] Images { get; set; }
	}
}
