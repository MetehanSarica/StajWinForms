using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StajWeb.Dtos;
using StajWeb.Helpers;
using System.Net.Http.Json;

namespace StajWeb.Pages.Admin
{
    public class SeferOtobusEslemeModel : AdminPageModel
    {
        private readonly IHttpClientFactory _clientFactory;
        public SeferOtobusEslemeModel(IHttpClientFactory clientFactory) => _clientFactory = clientFactory;

        public List<SeferDto> Seferler { get; set; } = new();
        public List<OtobusDto> Otobusler { get; set; } = new();
        public KullaniciYetkiDto? Yetki { get; set; }

        public async Task OnGetAsync()
        {
            Yetki = HttpContext.Session.GetYetki("sefer_otobus_esleme");
            var client = _clientFactory.CreateClient("API");
            Seferler = await client.GetFromJsonAsync<List<SeferDto>>("api/seferler") ?? new();
            Otobusler = await client.GetFromJsonAsync<List<OtobusDto>>("api/otobusler") ?? new();
        }

        public async Task<IActionResult> OnPostAtaAsync(int seferId, int otobusId)
        {
            var client = _clientFactory.CreateClient("API");
            await client.PutAsJsonAsync($"api/seferler/{seferId}/otobus", new { OtobusId = otobusId });
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostKaldirAsync(int seferId)
        {
            var client = _clientFactory.CreateClient("API");
            await client.DeleteAsync($"api/seferler/{seferId}/otobus");
            return RedirectToPage();
        }
    }
}
