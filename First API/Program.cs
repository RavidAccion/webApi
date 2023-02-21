using First_API.Data;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using First_API.Interface;
using First_API.Services
  ;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
 void ConfigureServices(IServiceCollection services)
{

    services.AddScoped<IElectronicscs, Electronicsdata>();

}

IServiceCollection serviceCollection = builder.Services.AddDbContext<StoreDB>(options =>
{
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultCS")
        );
});
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
