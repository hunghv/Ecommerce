using System;
using Data.Context;
using E.Shared.Utils;
using Ecommerce.Extension;
using Ioc;
using Logging.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace Ecommerce
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.InitComponent();
            services.AddSwagger();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDbContext<LoggingContext>(options =>
                options.UseMySql(Configuration.GetConnectionString(Connection.DatabaseName.Logging.ToString()),
                    mySqlOptionsAction => mySqlOptionsAction.ServerVersion(new Version(), ServerType.MySql)
                ));
            services.AddDbContext<EcommerceContext>(options =>
                options.UseMySql(Configuration.GetConnectionString(Connection.DatabaseName.Ecommerce.ToString()),
                    mySqlOptionsAction => mySqlOptionsAction.ServerVersion(new Version(), ServerType.MySql)
                ));
            
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.AddSwagger();
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
