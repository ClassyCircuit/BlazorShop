using Microsoft.Extensions.DependencyInjection;
using BlazorShop.Data.DataManagers;

namespace BlazorShop.Data
{
    public static class StartupExtensions
    {
        public static void AddDataLayer(this IServiceCollection services)
        {
            services.AddScoped<ProductDataManager>();
            services.AddScoped<FileManager>();
        }
    }
}
