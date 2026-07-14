using Microsoft.EntityFrameworkCore;
using StajWinForms_API.Models;
using Scalar.AspNetCore;
using System.Security.Cryptography;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
// dbStaj entegrasyonu
builder.Services.AddDbContext<DbStajContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DbStajConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

var apiKey = app.Configuration["ApiKey"]!;
app.Use(async (context, next) =>
{
    if (context.Request.Path.StartsWithSegments("/api"))
    {
        var apiKeyBytes = System.Text.Encoding.UTF8.GetBytes(apiKey);
        if (!context.Request.Headers.TryGetValue("X-Api-Key", out var gelenKey) ||
            !CryptographicOperations.FixedTimeEquals(
                apiKeyBytes,
                System.Text.Encoding.UTF8.GetBytes(gelenKey.ToString())))
        {
            context.Response.StatusCode = StatusCodes.Status401Unauthorized;
            await context.Response.WriteAsync("Geçersiz veya eksik API anahtarı.");
            return;
        }
    }
    await next();
});

app.UseAuthorization();

app.MapControllers();

app.Run();
