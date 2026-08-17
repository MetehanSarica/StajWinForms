using Microsoft.EntityFrameworkCore;
using StajWinForms_API.Models;
using Scalar.AspNetCore;
using System.Security.Cryptography;

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseWindowsService();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddCors(o => o.AddPolicy("Default", p =>
    p.WithOrigins("http://localhost:5920", "https://localhost:7250")
    .AllowAnyMethod()
    .AllowAnyHeader()));
builder.Services.AddOpenApi();
// dbStaj entegrasyonu
builder.Services.AddDbContext<DbStajContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DbStajConnection")));



var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapOpenApi();
app.MapScalarApiReference();

app.UseHttpsRedirection();
app.UseCors("Default");

app.Use(async (ctx, next) =>
{
    ctx.Response.Headers["X-Content-Type-Options"] = "nosniff";
    ctx.Response.Headers["X-Frame-Options"] = "DENY";
    ctx.Response.Headers["Referrer-Policy"] = "no-referrer";
    await next();
});

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

public partial class Program { }