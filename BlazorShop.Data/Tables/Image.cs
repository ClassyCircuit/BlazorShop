namespace BlazorShop.Data.Tables
{
	public class Image : BaseTable
	{
		public string Path { get; set; }
		public int Next { get; set; }
		public int Prev { get; set; }
		public Product Product { get; set; }
	}
}
