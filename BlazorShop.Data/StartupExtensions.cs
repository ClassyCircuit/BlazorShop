using BlazorShop.Data.DataManagers;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorShop.Data
{
    public static class StartupExtensions
    {
        public static void AddDataLayer(this IServiceCollection services, DataConfig dataConfig)
        {
            services.AddScoped<ProductDataManager>();
            services.AddScoped<FileManager>();
            services.AddSingleton(dataConfig);
        }
    }
}
