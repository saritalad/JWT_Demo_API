using Microsoft.EntityFrameworkCore;
using RazoEFrCodeFirstDemo.Models;
using Microsoft.AspNetCore.Identity;
using RazoEFrCodeFirstDemo.Areas.Identity.Data;

namespace RazoEFrCodeFirstDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            var connectionString = builder.Configuration.GetConnectionString("MyConstr") ?? throw new InvalidOperationException("Connection string 'AppDBContextConnection' not found.");

            builder.Services.AddDbContext<AppDBContext>(options =>
                options.UseSqlServer(connectionString));

                        builder.Services.AddDefaultIdentity<RazoEFrCodeFirstDemoUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<RazoEFrCodeFirstDemoContext>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();
                        app.UseAuthentication();;

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}