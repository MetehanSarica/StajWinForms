using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using StajWinForms_API.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http.Json;
using System.Text;

namespace StajWinForms.Tests
{
    public class ApiTestFixture : IDisposable
    {
        private readonly SqliteConnection _keepAlive;
        public WebApplicationFactory<Program> Factory { get; }

        public ApiTestFixture()
        {
            // Keep one connection open so the shared in-memory DB survives between scopes
            _keepAlive = new SqliteConnection("Data Source=testdb;Mode=Memory;Cache=Shared");
            _keepAlive.Open();

            var sqliteOptions = new DbContextOptionsBuilder<DbStajContext>()
                .UseSqlite("Data Source=testdb;Mode=Memory;Cache=Shared")
                .Options;

            Factory = new WebApplicationFactory<Program>().WithWebHostBuilder(builder =>
                builder.ConfigureTestServices(services =>
                {
                    services.RemoveAll<DbContextOptions<DbStajContext>>();
                    services.RemoveAll<DbStajContext>();
                    services.AddScoped<DbStajContext>(_ => new DbStajContext(sqliteOptions));
                }));

            using var scope = Factory.Services.CreateScope();
            var db = scope.ServiceProvider.GetRequiredService<DbStajContext>();
            db.Database.EnsureCreated();
        }

        public void Dispose()
        {
            Factory.Dispose();
            _keepAlive.Dispose();
        }
    }

    public class ApiTests : IClassFixture<ApiTestFixture>
    {
        private readonly HttpClient _client;
        private readonly WebApplicationFactory<Program> _factory;

        public ApiTests(ApiTestFixture fixture)
        {
            _factory = fixture.Factory;
            _client = _factory.CreateClient();
            _client.DefaultRequestHeaders.Add("X-Api-Key", "staj-2026-gizli-anahtar");
        }

        [Fact]
        public async Task GetSeferler_Returns200()
        {
            var response = await _client.GetAsync("/api/seferler");
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task Login_YanlisParola_Returns401()
        {
            var response = await _client.PostAsJsonAsync("/api/auth/login",
                new { KullaniciAdi = "admin", Sifre = "yanlis" });
            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        }

        [Fact]
        public async Task ApiKey_Olmadan_Returns401()
        {
            var client2 = _factory.CreateClient();
            var response = await client2.GetAsync("/api/seferler");
            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        }

        [Fact]
        public async Task SeferGuncelle_KapasiteBiletinAltinda_Returns400()
        {

        }
    }
}
