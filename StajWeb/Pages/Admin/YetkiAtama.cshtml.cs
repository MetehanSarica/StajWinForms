using Microsoft.AspNetCore.Mvc;
using StajWeb.Dtos;
using StajWeb.Helpers;
using System.Net.Http.Json;

namespace StajWeb.Pages.Admin
{
    public class YetkiAtamaModel : AdminPageModel
    {
        private readonly IHttpClientFactory _clientFactory;
        public YetkiAtamaModel(IHttpClientFactory clientFactory) => _clientFactory = clientFactory;

        public static readonly Dictionary<string, string> FormAdlari = new()
        {
            ["btnFirmaBrowser"]    = "Firma Yönetimi",
            ["btnOtobusBrowser"]   = "Otobüs Yönetimi",
            ["btnFirmaOtobusEsle"] = "Firma-Otobüs Eşleme",
            ["btnKaptanBrowser"]   = "Kaptan Yönetimi",
            ["btnKaptanEsle"]      = "Otobüs-Kaptan Eşleme",
            ["btnSeferOtobusEsle"] = "Sefer-Otobüs Eşleme",
            ["btnKullaniciYonetim"]= "Kullanıcı Yönetimi",
            ["btnYetkiAtama"]      = "Yetki Atama"
        };

        public List<KullaniciDto> Kullanicilar { get; set; } = new();
        public List<KullaniciYetkiDto> Yetkiler { get; set; } = new();
        public KullaniciDto? SeciliKullanici { get; set; }
        public KullaniciYetkiDto? Yetki { get; set; }

        public async Task OnGetAsync(int? kullaniciId)
        {
            Yetki = HttpContext.Session.GetYetki("btnYetkiAtama");
            var client = _clientFactory.CreateClient("API");
            Kullanicilar = await client.GetFromJsonAsync<List<KullaniciDto>>("api/kullanicilar") ?? new();

            if (kullaniciId.HasValue)
            {
                SeciliKullanici = Kullanicilar.FirstOrDefault(k => k.KullaniciId == kullaniciId);
                Yetkiler = await client.GetFromJsonAsync<List<KullaniciYetkiDto>>(
                    $"api/kullanicilar/{kullaniciId}/yetkiler") ?? new();
            }
        }

        public async Task<IActionResult> OnPostKaydetAsync(int kullaniciId)
        {
            var yetkiler = FormAdlari.Keys.Select(f => new KullaniciYetkiDto
            {
                FormAdi   = f,
                Ekle      = Request.Form[$"ekle_{f}"]      == "on",
                Sil       = Request.Form[$"sil_{f}"]       == "on",
                Degistir  = Request.Form[$"degistir_{f}"]  == "on",
                Incele    = Request.Form[$"incele_{f}"]    == "on",
                Ata       = Request.Form[$"ata_{f}"]       == "on",
                Kaldir    = Request.Form[$"kaldir_{f}"]    == "on",
                Kaydet    = Request.Form[$"kaydet_{f}"]    == "on",
            }).ToList();

            var client = _clientFactory.CreateClient("API");
            await client.PutAsJsonAsync($"api/kullanicilar/{kullaniciId}/yetkiler", yetkiler);
            return RedirectToPage(new { kullaniciId });
        }
    }
}
