using JC_ViaBrasil.Data;
using JC_ViaBrasil.Interfaces;
using JC_ViaBrasil.Mapping;
using JC_ViaBrasil.Repositories;
using JC_ViaBrasil.Repositories.Interfaces;
using JC_ViaBrasil.Rest;
using JC_ViaBrasil.Services;
using Microsoft.EntityFrameworkCore;

namespace JC_ViaBrasil
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddEntityFrameworkSqlServer()
                .AddDbContext<TabelaFipeDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Database")));

            builder.Services.AddScoped<IBrasilApi, BrasilApiRest>();
            builder.Services.AddScoped<ITabelaFipeService, TabelaFipeService>();
            builder.Services.AddScoped<ITabelaFipeRepository, TabelaFipeRepository>();

            builder.Services.AddAutoMapper(typeof(TabelaFipeMapping));

            builder.Services.AddCors();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors(opcoes => opcoes.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.MapControllers();

            app.Run();
        }
    }
}