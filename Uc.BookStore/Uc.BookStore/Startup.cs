using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Uc.BookStore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();


            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.Map("/", async context =>
                {
                    if (env.IsDevelopment())
                    {
                        await context.Response.WriteAsync("Hello From Dev");
                    }
                    else if (env.IsStaging())
                    {
                        await context.Response.WriteAsync("Hello From Stag");

                    }
                    else if (env.IsProduction())
                    {
                        await context.Response.WriteAsync("Hello from Prod");
                    }
                    else if (env.IsEnvironment("prod"))
                    {
                        await context.Response.WriteAsync("Hello from custom env"); 
                    }
                    else
                    await context.Response.WriteAsync("Hello World!");
                });
            });
            

            app.UseEndpoints(endpoints =>
            {
                endpoints.Map("/umesh", async context =>
                {
                    await context.Response.WriteAsync("Hello Umesh!");
                });
            });
        }
    }
}
