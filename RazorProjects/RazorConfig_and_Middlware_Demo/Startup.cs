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

namespace RazorConfig_and_Middlware_Demo
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

            app.UseStaticFiles();// keep static file in root folder

            app.UseRouting();
            //custom middleware component
           // app.UseSample();
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("\n<h1> Request1 Handler Middlware ");
            //    await next();
            //    await context.Response.WriteAsync("\n<h1> Response1 Handler Middlware ");

            //} );


            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("\n<h1> Request2 Handler Middlware ");
            //    await next();
            //    await context.Response.WriteAsync("\n<h1> Response2 Handler Middlware ");

            //}
            //        );


            //app.Run(async (context) =>
            //{

            //    await context.Response.WriteAsync("\n<h1>Company Name is </h2>" + Configuration["company"]);
            //});

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });




        }
    }
}
