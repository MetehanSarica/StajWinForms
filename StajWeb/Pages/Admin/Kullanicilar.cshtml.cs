using Microsoft.AspNetCore.Mvc;
using StajWeb.Dtos;
using StajWeb.Helpers;
using System.Net.Http.Json;

namespace StajWeb.Pages.Admin
{
    public class KullanicilarModel : AdminPageModel
    {
        private readonly IHttpClientFactory _clientFactory;
        public KullanicilarModel(IHttpClientFactory clientFactory) => _clientFactory = clientFactory;

        public List<KullaniciDto> Kullanicilar { get; set; } = new();
        public KullaniciYetkiDto? Yetki { get; set; }

        public async Task OnGetAsync()
        {
            Yetki = HttpContext.Session.GetYetki("kullanici_yonetimi");
            var client = _clientFactory.CreateClient("API");
            Kullanicilar = await client.GetFromJsonAsync<List<KullaniciDto>>("api/kullanicilar") ?? new();
        }

        public async Task<IActionResult> OnPostEkleAsync(string kullaniciAdi, string sifre, string? adSoyad, bool aktif)
        {
            var client = _clientFactory.CreateClient("API");
            await client.PostAsJsonAsync("api/kullanicilar", new
            {
                KullaniciAdi = kullaniciAdi.Trim(),
                Sifre = sifre,
                AdSoyad = string.IsNullOrWhiteSpace(adSoyad) ? null : adSoyad.Trim(),
                Aktif = aktif
            });
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostGuncelleAsync(int kullaniciId, string kullaniciAdi,
            string? yeniSifre, string? adSoyad, bool aktif)
        {
            var client = _clientFactory.CreateClient("API");
            await client.PutAsJsonAsync($"api/kullanicilar/{kullaniciId}", new
            {
                KullaniciAdi = kullaniciAdi.Trim(),
                YeniSifre = string.IsNullOrWhiteSpace(yeniSifre) ? null : yeniSifre,
                AdSoyad = string.IsNullOrWhiteSpace(adSoyad) ? null : adSoyad.Trim(),
                Aktif = aktif
            });
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostSilAsync(int kullaniciId)
        {
            var oturum = HttpContext.Session.GetOturum();
            if (oturum?.KullaniciId == kullaniciId)
                return RedirectToPage();

            var client = _clientFactory.CreateClient("API");
            await client.DeleteAsync($"api/kullanicilar/{kullaniciId}");
            return RedirectToPage();
        }
    }
}
