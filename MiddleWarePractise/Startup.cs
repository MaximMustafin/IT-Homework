using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MiddleWarePractise.CustomMiddlewares;

namespace MiddleWarePractise
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseMiddleware<AuthenticationMiddleware>();
            app.UseMiddleware<ResponseLoggingMiddleware>();
            app.UseMiddleware<RequestLoggingMiddleware>();
            //app.Use(async (context, next) =>
            //{
            //    int x = 0;
            //    int y = 8 / x;
            //    await context.Response.WriteAsync($"Result = {y}");
            //});
            app.Map("/customError500", ap => ap.Run(async (context) =>
            {
                int[] array = { 1, 2, 3, 4, 5 };
                await context.Response.WriteAsync($"{array[5]}\n");
            }));
            app.Map("/hello", ap => ap.Run(async (context) =>
            {
                await context.Response.WriteAsync($"Welcome back!!!");
            }));

        }
    }
}
