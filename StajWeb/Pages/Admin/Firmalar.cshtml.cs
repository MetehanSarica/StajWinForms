using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StajWeb.Dtos;
using StajWeb.Helpers;
using System.Net.Http.Json;

namespace StajWeb.Pages.Admin
{
    public class FirmalarModel : AdminPageModel
    {
        private readonly IHttpClientFactory _clientFactory;
        public FirmalarModel(IHttpClientFactory clientFactory) => _clientFactory = clientFactory;

        public List<FirmaDto> Firmalar { get; set; } = new();
        public KullaniciYetkiDto? Yetki { get; set; }

        public async Task OnGetAsync()
        {
            Yetki = HttpContext.Session.GetYetki("firma_yonetimi");
            var client = _clientFactory.CreateClient("API");
            Firmalar = await client.GetFromJsonAsync<List<FirmaDto>>("api/firmalar") ?? new();
        }

        public async Task<IActionResult> OnPostEkleAsync(string firmaAdi)
        {
            if (HttpContext.Session.GetYetki("firma_yonetimi")?.Ekle != true) return Forbid();
            var client = _clientFactory.CreateClient("API");
            await client.PostAsJsonAsync("api/firmalar", new { FirmaAdi = firmaAdi });
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostGuncelleAsync(int firmaId, string firmaAdi)
        {
            if (HttpContext.Session.GetYetki("firma_yonetimi")?.Degistir != true) return Forbid();
            var client = _clientFactory.CreateClient("API");
            await client.PutAsJsonAsync($"api/firmalar/{firmaId}", new { FirmaAdi = firmaAdi });
            return RedirectToPage();
        }
        public async Task<IActionResult> OnPostSilAsync(int firmaId)
        {
            if (HttpContext.Session.GetYetki("firma_yonetimi")?.Sil != true) return Forbid();
            var client = _clientFactory.CreateClient("API");
            await client.DeleteAsync($"api/firmalar/{firmaId}");
            return RedirectToPage();
        }
       
    }
}
