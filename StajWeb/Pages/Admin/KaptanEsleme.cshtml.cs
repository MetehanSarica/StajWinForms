using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StajWeb.Dtos;
using StajWeb.Helpers;
using System.Net.Http.Json;

namespace StajWeb.Pages.Admin
{
    public class KaptanEslemeModel : AdminPageModel
    {
        private readonly IHttpClientFactory _clientFactory;
        public KaptanEslemeModel(IHttpClientFactory clientFactory) => _clientFactory = clientFactory;

        public List<OtobusDto> Otobusler { get; set; } = new();
        public List<PersonelDto> TumKaptanlar { get; set; } = new();
        public List<OtobusKaptanDto> AtanmisKaptanlar { get; set; } = new();
        public KullaniciYetkiDto? Yetki { get; set; }

        public async Task OnGetAsync(int? seciliOtobusId)
        {
            Yetki = HttpContext.Session.GetYetki("btnKaptanEsle");
            var client = _clientFactory.CreateClient("API");
            Otobusler = await client.GetFromJsonAsync<List<OtobusDto>>("api/otobusler") ?? new();
            TumKaptanlar = await client.GetFromJsonAsync<List<PersonelDto>>("api/personel") ?? new();
            TumKaptanlar = TumKaptanlar.Where(p => p.Unvan == "Şoför" || p.Unvan == "Kaptan").ToList();

            var oid = seciliOtobusId ?? Otobusler.FirstOrDefault()?.OtobusId;
            if (oid.HasValue)
                AtanmisKaptanlar = await client.GetFromJsonAsync<List<OtobusKaptanDto>>($"api/otobuskaptan/{oid}") ?? new();
        }

        public async Task<IActionResult> OnPostAtaAsync(int otobusId, int personelId)
        {
            var client = _clientFactory.CreateClient("API");
            await client.PostAsJsonAsync("api/otobuskaptan", new { OtobusId = otobusId, PersonelId = personelId });
            return RedirectToPage(new { seciliOtobusId = otobusId });
        }

        public async Task<IActionResult> OnPostKaldirAsync(int atamaId, int otobusId)
        {

            var client = _clientFactory.CreateClient("API");
            await client.DeleteAsync($"api/otobuskaptan/{atamaId}");
            return RedirectToPage(new { seciliOtobusId = otobusId });
        }
    }
}