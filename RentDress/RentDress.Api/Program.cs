using Microsoft.AspNetCore.Cors.Infrastructure;
using RentDress.Core.Entities;
using RentDress.Core.IRepository;
using RentDress.Core.IService;
using RentDress.Data;
using RentDress.Data.Repository;
using RentDress.Service;

namespace RentDress.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddScoped<IDressService, DressService>();
            builder.Services.AddScoped<IRepository<DressEntity>, DressRepository>();


            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IRepository<UserEntity>, UserRepository>();
            

            builder.Services.AddScoped<IAvailabilityService, AvailabilityService>();
            builder.Services.AddScoped<IRepository<AvailabilityEntity>, AvailabilityRepository>();


            builder.Services.AddScoped<IRentService, RentService>();
            builder.Services.AddScoped<IRepository<RentEntity>, RentRepository>();


            builder.Services.AddScoped<IRentDetailsService, RentDetailsService>();
            builder.Services.AddScoped<IRepository<RentDetailsEntity>, RentDetailsRepository>();


            builder.Services.AddSingleton<DataContext>();
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

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}