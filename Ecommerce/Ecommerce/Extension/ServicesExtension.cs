using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;

namespace Ecommerce.Extension
{
    public static class ServicesExtension 
    {
        public  static void AddSwagger(this IServiceCollection service)
        {
            service.AddSwaggerGen(c =>
             {
                 c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
             });
        }
    }
}
