using Microsoft.Extensions.DependencyInjection;

namespace Maanfee.Highcharts
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddHighCharts(this IServiceCollection services)
        {
            services.AddScoped<Chart>();

            return services;
        }
    }
  
}
