using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StajWeb.Dtos;
using StajWeb.Helpers;
using System.Net.Http.Json;

namespace StajWeb.Pages.Admin
{
    public class FirmaOtobusEslemeModel : AdminPageModel
    {
        private readonly IHttpClientFactory _clientFactory;
        public FirmaOtobusEslemeModel(IHttpClientFactory clientFactory) => _clientFactory = clientFactory;

        public List<FirmaDto> Firmalar { get; set; } = new();
        public List<OtobusDto> Otobusler { get; set; } = new();
        public KullaniciYetkiDto? Yetki { get; set; }

        public async Task OnGetAsync()
        {
            Yetki = HttpContext.Session.GetYetki("firma_otobus_esleme");
            var client = _clientFactory.CreateClient("API");
            Firmalar = await client.GetFromJsonAsync<List<FirmaDto>>("api/firmalar") ?? new();
            Otobusler = await client.GetFromJsonAsync<List<OtobusDto>>("api/otobusler") ?? new();
        }

        public async Task<IActionResult> OnPostAtaAsync(int otobusId, int firmaId)
        {
            var client = _clientFactory.CreateClient("API");
            await client.PutAsJsonAsync($"api/otobusler/{otobusId}/firma", firmaId);
            return RedirectToPage(new { seciliFirmaId = firmaId });
        }

        public async Task<IActionResult> OnPostKaldirAsync(int otobusId, int firmaId)
        {
            var client = _clientFactory.CreateClient("API");
            await client.PutAsJsonAsync<int?>($"api/otobusler/{otobusId}/firma", null);
            return RedirectToPage(new { seciliFirmaId = firmaId });
        }
    }
}
