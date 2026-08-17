using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StajWeb.Dtos;
using StajWeb.Helpers;
using StajWeb.Models;
using System.Net.Http.Json;

namespace StajWeb.Pages.Admin
{
    public class OtogarlarModel : AdminPageModel
    {
        private readonly IHttpClientFactory _clientFactory;
        public List<OtogarDto> Otogarlar { get; set; } = new();
        public List<Sehirler> Sehirler { get; set; } = new();
        public KullaniciYetkiDto? Yetki { get; set; }

        public OtogarlarModel(IHttpClientFactory clientFactory) => _clientFactory = clientFactory;

        public async Task OnGetAsync()
        {
            Yetki = HttpContext.Session.GetYetki("otogar_yonetimi");
            var client = _clientFactory.CreateClient("API");
            Otogarlar = await client.GetFromJsonAsync<List<OtogarDto>>("api/otogarlar") ?? new();
            Sehirler = await client.GetFromJsonAsync<List<Sehirler>>("api/sehirler") ?? new();
        }

        public async Task<IActionResult> OnPostEkleAsync(int sehirId, string otogarAdi, string? adres, string? telefon)
        {
            if (HttpContext.Session.GetYetki("otogar_yonetimi")?.Ekle != true) return Forbid();
            var client = _clientFactory.CreateClient("API");
            await client.PostAsJsonAsync("api/otogarlar", new { SehirId = sehirId, OtogarAdi = otogarAdi, Adres = adres, Telefon = telefon });
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostDuzenleAsync(int otogarId, int sehirId, string otogarAdi, string? adres, string? telefon)
        {
            if (HttpContext.Session.GetYetki("otogar_yonetimi")?.Degistir != true) return Forbid();
            var client = _clientFactory.CreateClient("API");
            await client.PutAsJsonAsync($"api/otogarlar/{otogarId}", new { SehirId = sehirId, OtogarAdi = otogarAdi, Adres = adres, Telefon = telefon });
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostSilAsync(int otogarId)
        {
            if (HttpContext.Session.GetYetki("otogar_yonetimi")?.Sil != true) return Forbid();
            var client = _clientFactory.CreateClient("API");
            await client.DeleteAsync($"api/otogarlar/{otogarId}");
            return RedirectToPage();
        }
    }
}