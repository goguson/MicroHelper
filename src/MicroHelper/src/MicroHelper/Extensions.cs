
using Microsoft.Extensions.Configuration;

namespace MicroHelper
{
    public static class Extensions
    {
        public static T GetOptions<T>(this IConfiguration configuration, string sectionName)
            where T : new()
        {
            var model = new T();
            configuration.GetSection(sectionName).Bind(model);
            return model;
        }
    }
}
