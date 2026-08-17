using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StajWeb.Dtos;
using StajWeb.Helpers;
using StajWeb.Models;
using System.Net.Http.Json;

namespace StajWeb.Pages.Admin
{
    public class MusterilerModel : AdminPageModel
    {
        private readonly IHttpClientFactory _clientFactory;
        public List<MusteriDto> Musteriler { get; set; } = new();
        public KullaniciYetkiDto? Yetki { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? Ara { get; set; }

        public MusterilerModel(IHttpClientFactory clientFactory) => _clientFactory = clientFactory;

        public async Task OnGetAsync()
        {
            Yetki = HttpContext.Session.GetYetki("musteri_yonetimi");
            var client = _clientFactory.CreateClient("API");
            var url = "api/musteri" + (string.IsNullOrEmpty(Ara) ? "" : $"?ara={Uri.EscapeDataString(Ara)}");
            Musteriler = await client.GetFromJsonAsync<List<MusteriDto>>(url) ?? new();
        }

        public async Task<IActionResult> OnPostSilAsync(int id)
        {
            if (HttpContext.Session.GetYetki("musteri_yonetimi")?.Sil != true) return Forbid();
            var client = _clientFactory.CreateClient("API");
            await client.DeleteAsync($"api/musteri/{id}");
            return RedirectToPage();
        }

        public async Task<IActionResult> OnGetBiletlerAsync(int id)
        {
            var client = _clientFactory.CreateClient("API");
            var response = await client.GetAsync($"api/musteri/{id}/biletler");
            var json = await response.Content.ReadAsStringAsync();
            return Content(json, "application/json");
        }
    }
}
