using BlazorShop.Business.Helpers;
using BlazorShop.Business.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorShop.Business
{
    public static class StartupExtensions
    {
        public static void AddBusinessLayer(this IServiceCollection services)
        {
            services.AddScoped<ProductService>();
            services.AddScoped<ImageService>();
            services.AddScoped<HashingHelper>();
        }
    }
}
