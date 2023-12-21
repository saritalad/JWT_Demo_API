using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace RazorConfig_and_Middlware_Demo
{
    public class SampleMiddleware
    {
        private RequestDelegate _next { get; }
        public SampleMiddleware(RequestDelegate next)
        {

            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {

            await context.Response.WriteAsync("\n<h1> request from Sample Middleware </h1>");
            await _next.Invoke(context);
            await context.Response.WriteAsync("\n<h1> Response from Sample Middleware </h1>");

        }
    }
        public static class MiddlewareExtensions
        {
            public static IApplicationBuilder  UseSample(this IApplicationBuilder app)
            {

                return app.UseMiddleware<SampleMiddleware>();
            }



        }
    
}
