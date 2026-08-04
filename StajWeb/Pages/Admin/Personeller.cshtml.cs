using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StajWeb.Dtos;
using StajWeb.Helpers;
using System.Net.Http.Json;

namespace StajWeb.Pages.Admin
{
    public class PersonellerModel : AdminPageModel
    {
        private readonly IHttpClientFactory _clientFactory;
        public List<PersonelDto> Personeller { get; set; } = new();
        public KullaniciYetkiDto? Yetki { get; set; }

        public PersonellerModel(IHttpClientFactory clientFactory) => _clientFactory = clientFactory;


        public async Task OnGetAsync()
        {
            Yetki = HttpContext.Session.GetYetki("btnPersonelBrowser");
            var client = _clientFactory.CreateClient("API");
            Personeller = await client.GetFromJsonAsync<List<PersonelDto>>("api/personel") ?? new();
        }

        public async Task<IActionResult> OnPostEkleAsync(string ad, string soyad, string? email, string? unvan, decimal? maas, DateOnly? iseGirisTarihi)
        {
            var client = _clientFactory.CreateClient("API");
            await client.PostAsJsonAsync("api/personel", new { Ad = ad, Soyad = soyad, Email = email, Unvan = unvan, Maas = maas, IseGirisTarihi = iseGirisTarihi });
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostDuzenleAsync(int id, string ad, string soyad, string? email, string? unvan, decimal? maas, DateOnly? iseGirisTarihi)
        {
            var client = _clientFactory.CreateClient("API");
            await client.PutAsJsonAsync($"api/personel/{id}", new { Ad = ad, Soyad = soyad, Email = email, Unvan = unvan, Maas = maas, IseGirisTarihi = iseGirisTarihi });
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostSilAsync(int id)
        {
            var client = _clientFactory.CreateClient("API");
            await client.DeleteAsync($"api/personel/{id}");
            return RedirectToPage();
        }
    }
}