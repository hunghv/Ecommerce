using Data.Context;
using Microsoft.Extensions.DependencyInjection;

namespace Ioc
{
    public static class ComponentRegistrar
    {
        public static void InitComponent(this IServiceCollection services)
        {
            services.AddScoped(typeof(EcommerceContext), typeof(EcommerceContext));
        }
    }
}
