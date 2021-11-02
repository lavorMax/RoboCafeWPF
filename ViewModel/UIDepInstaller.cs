using Microsoft.Extensions.DependencyInjection;

namespace ViewModel
{
    public static class UIDep
    {
        public static IServiceCollection RegDepUI(this IServiceCollection services)
        {
            services.AddScoped<ReastaurantViewModel>();
            return services;
        }
    }
}
