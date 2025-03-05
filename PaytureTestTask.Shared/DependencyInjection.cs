using Microsoft.Extensions.DependencyInjection;
using PaytureTestTask.Application.Interfaces;
using PaytureTestTask.Shared.PaytureProvider;

namespace PaytureTestTask.Shared
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddShared(this IServiceCollection services)
        {
            services.AddScoped<IPaytureApi, PaytureApi>();

            return services;
        }
    }
}
