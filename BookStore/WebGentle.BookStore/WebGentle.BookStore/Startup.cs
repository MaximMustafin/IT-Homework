using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebGentle.BookStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.Use(async(context, next) => 
            //{
            //    await context.Response.WriteAsync("Hello from my first middleware\n");

            //    await next();

            //    await context.Response.WriteAsync("Hello from my first middleware response\n");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from my second middleware\n");

            //    await next();

            //    await context.Response.WriteAsync("Hello from my second middleware response\n");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from my third middleware\n");                

            //    await context.Response.WriteAsync("Hello from my third middleware response\n");

            //    await next();
            //});

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.Map("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.Map("/", async context =>
            //    {
            //        if (env.IsDevelopment()) 
            //        {
            //            await context.Response.WriteAsync("Hello from development!");
            //        }
            //        else if (env.IsProduction())
            //        {
            //            await context.Response.WriteAsync("Hello from production!");
            //        }
            //        else if (env.IsStaging())
            //        {
            //            await context.Response.WriteAsync("Hello from staging!");
            //        }
            //        else if (env.IsEnvironment("MyEnv")) 
            //        {
            //            await context.Response.WriteAsync("Hello from MyEnv!");
            //        }
            //        else
            //        await context.Response.WriteAsync(env.EnvironmentName);
            //    });
            //});

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.Map("/maksim", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello Maksim!\n");
            //    });
            //});
        }
    }
}
