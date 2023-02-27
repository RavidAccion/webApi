using First_API.Data;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using First_API.Interface;
using First_API.Services
  ;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.




/*builder.Services.AddScoped<IDbContext, StoreDB>();*/
builder.Services.AddScoped<Istores, storesService>();
builder.Services.AddScoped<Iproduct, ProductServices>();
builder.Services.AddScoped<Icategory, categoryServices>();

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
