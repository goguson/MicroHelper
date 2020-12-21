
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MicroHelper
{
    public static class Extensions
    {
        public static T GetOptions<T>(this IConfiguration configuration, string settingsSectionName)
            where T : new()
        {
            var model = new T();
            configuration.GetSection(settingsSectionName).Bind(model);
            return model;
        }
        public static T GetOptions<T>(this IServiceCollection services, string settingsSectionName)
            where T : new()
        {
            using var serviceProvider = services.BuildServiceProvider();
            var configuration = serviceProvider.GetService<IConfiguration>();
            return configuration.GetOptions<T>(settingsSectionName);
        }
    }
}
