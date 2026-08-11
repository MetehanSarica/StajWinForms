using Microsoft.AspNetCore.Mvc;
using StajWeb.Dtos;
using StajWeb.Helpers;
using System.Net.Http.Json;

namespace StajWeb.Pages.Admin
{
    public class OtobuslerModel : AdminPageModel
    {
        private readonly IHttpClientFactory _clientFactory;
        public OtobuslerModel(IHttpClientFactory clientFactory) => _clientFactory = clientFactory;

        public List<OtobusDto> Otobusler { get; set; } = new();
        public List<FirmaDto> Firmalar { get; set; } = new();
        public KullaniciYetkiDto? Yetki { get; set; }

        public async Task OnGetAsync()
        {
            Yetki = HttpContext.Session.GetYetki("otobus_yonetimi");
            var client = _clientFactory.CreateClient("API");
            Otobusler = await client.GetFromJsonAsync<List<OtobusDto>>("api/otobusler") ?? new();
            Firmalar = await client.GetFromJsonAsync<List<FirmaDto>>("api/firmalar") ?? new();
        }

        public async Task<IActionResult> OnPostEkleAsync(string plaka, string marka, string model,
            int koltukKapasitesi, int? firmaId)
        {
            var client = _clientFactory.CreateClient("API");
            await client.PostAsJsonAsync("api/otobusler", new
            {
                Plaka = plaka.Trim().ToUpper(),
                Marka = marka,
                Model = model,
                KoltukKapasitesi = koltukKapasitesi,
                FirmaId = firmaId == 0 ? (int?)null : firmaId
            });
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostGuncelleAsync(int otobusId, string plaka, string marka,
            string model, int koltukKapasitesi, int? firmaId)
        {
            var client = _clientFactory.CreateClient("API");
            await client.PutAsJsonAsync($"api/otobusler/{otobusId}", new
            {
                Plaka = plaka.Trim().ToUpper(),
                Marka = marka,
                Model = model,
                KoltukKapasitesi = koltukKapasitesi,
                FirmaId = firmaId == 0 ? (int?)null : firmaId
            });
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostSilAsync(int otobusId)
        {
            var client = _clientFactory.CreateClient("API");
            await client.DeleteAsync($"api/otobusler/{otobusId}");
            return RedirectToPage();
        }
    }
}
