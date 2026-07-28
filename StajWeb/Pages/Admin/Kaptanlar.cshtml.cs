using Microsoft.AspNetCore.Mvc;
using StajWeb.Dtos;
using StajWeb.Helpers;
using System.Net.Http.Json;

namespace StajWeb.Pages.Admin
{
    public class KaptanlarModel : AdminPageModel
    {
        private readonly IHttpClientFactory _clientFactory;
        public KaptanlarModel(IHttpClientFactory clientFactory) => _clientFactory = clientFactory;

        public List<PersonelDto> Kaptanlar { get; set; } = new();
        public KullaniciYetkiDto? Yetki { get; set; }

        public async Task OnGetAsync()
        {
            Yetki = HttpContext.Session.GetYetki("btnKaptanBrowser");
            var client = _clientFactory.CreateClient("API");
            Kaptanlar = await client.GetFromJsonAsync<List<PersonelDto>>("api/personel") ?? new();
        }

        public async Task<IActionResult> OnPostEkleAsync(string ad, string soyad, string? email,
            decimal? maas, DateOnly? iseGirisTarihi)
        {
            var client = _clientFactory.CreateClient("API");
            var resp = await client.PostAsJsonAsync("api/personel", new
            {
                Ad = ad.Trim(),
                Soyad = soyad.Trim(),
                Email = string.IsNullOrWhiteSpace(email) ? null : email.Trim(),
                Maas = maas > 0 ? maas : null,
                IseGirisTarihi = iseGirisTarihi ?? DateOnly.FromDateTime(DateTime.Today)
            });
            if (!resp.IsSuccessStatusCode)
                TempData["Hata"] = await resp.Content.ReadAsStringAsync();
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostGuncelleAsync(int personelId, string ad, string soyad,
            string? email, decimal? maas, DateOnly? iseGirisTarihi)
        {
            var client = _clientFactory.CreateClient("API");
            var resp = await client.PutAsJsonAsync($"api/personel/{personelId}", new
            {
                Ad = ad.Trim(),
                Soyad = soyad.Trim(),
                Email = string.IsNullOrWhiteSpace(email) ? null : email.Trim(),
                Maas = maas > 0 ? maas : null,
                IseGirisTarihi = iseGirisTarihi ?? DateOnly.FromDateTime(DateTime.Today)
            });
            if (!resp.IsSuccessStatusCode)
                TempData["Hata"] = await resp.Content.ReadAsStringAsync();
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostSilAsync(int personelId)
        {
            var client = _clientFactory.CreateClient("API");
            await client.DeleteAsync($"api/personel/{personelId}");
            return RedirectToPage();
        }
    }
}
