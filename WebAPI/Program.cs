using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System.Configuration;
using WebAPI.Business;
using WebAPI.Contracts;
using WebAPI.Middlewares;
using WebAPI.Profiles;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//Injector
builder.Services.AddAutoMapper(typeof(ProductProfile));
builder.Services.AddSingleton<IProductBusiness, ProductBusiness>();


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

//Write Custom Middleware

//app.UseLogUrl();

app.MapControllers();

app.Run();
