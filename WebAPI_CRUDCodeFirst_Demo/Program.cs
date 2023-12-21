using Microsoft.EntityFrameworkCore;
using WebAPI_CRUDCodeFirst_Demo.Models;

namespace WebAPI_CRUDCodeFirst_Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("MyConstr") ?? throw new InvalidOperationException("Connection string 'AppDBContextConnection' not found.");

            builder.Services.AddDbContext<AppDBContext>(options =>
                options.UseSqlServer(connectionString));
            //builder.Services.AddCors(setup =>
            // {
            //     setup.AddPolicy("default", options =>
            //     {
            //         options.AllowAnyHeader().AllowAnyOrigin().AllowAnyOrigin().AllowAnyMethod();
            //     });

            // });
            builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
            {
                builder.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
            }));
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseRouting();
            app.UseAuthorization();
            app.UseCors("corsapp");

            app.MapControllers();

            app.Run();
        }
    }
}