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

        public static readonly Dictionary<string, (string Baslik, HashSet<string> Yetkiler)> FormYetkileri = new()
        {
            ["btnDashboard"]        = ("Dashboard",             new() { "Incele" }),
            ["btnSeferBrowser"]     = ("Sefer Yönetimi",        new() { "Ekle", "Degistir", "Sil", "Incele", "AktifPasif" }),
            ["btnBiletArama"]       = ("Bilet Arama",           new() { "Incele" }),
            ["btnFirmaBrowser"]     = ("Firma Yönetimi",        new() { "Ekle", "Degistir", "Sil", "Incele" }),
            ["btnOtobusBrowser"]    = ("Otobüs Yönetimi",       new() { "Ekle", "Degistir", "Sil", "Incele" }),
            ["btnMusteriBrowser"]   = ("Müşteri Yönetimi",      new() { "Ekle", "Degistir", "Sil", "Incele" }),
            ["btnOtogarBrowser"]    = ("Otogar Yönetimi",       new() { "Ekle", "Degistir", "Sil" }),
            ["btnPersonelBrowser"]  = ("Personel Yönetimi",     new() { "Ekle", "Degistir", "Sil" }),
            ["btnFirmaOtobusEsle"]  = ("Firma-Otobüs Eşleme",  new() { "Ata", "Kaldir" }),
            ["btnKaptanEsle"]       = ("Otobüs-Kaptan Eşleme", new() { "Ata", "Kaldir" }),
            ["btnSeferOtobusEsle"]  = ("Sefer-Otobüs Eşleme",  new() { "Ata", "Kaldir" }),
            ["btnKullaniciYonetim"] = ("Kullanıcı Yönetimi",   new() { "Ekle", "Degistir", "Sil", "Incele" }),
            ["btnYetkiAtama"]       = ("Yetki Atama",           new() { "Kaydet" }),
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
            var yetkiler = FormYetkileri.Keys.Select(f => new KullaniciYetkiDto
            {
                FormAdi = f,
                Ekle = Request.Form[$"ekle_{f}"] == "on",
                Sil = Request.Form[$"sil_{f}"] == "on",
                Degistir = Request.Form[$"degistir_{f}"] == "on",
                Incele = Request.Form[$"incele_{f}"] == "on",
                Ata = Request.Form[$"ata_{f}"] == "on",
                Kaldir = Request.Form[$"kaldir_{f}"] == "on",
                Kaydet = Request.Form[$"kaydet_{f}"] == "on",
                AktifPasif = Request.Form[$"aktifpasif_{f}"] == "on",
            }).ToList();

            var client = _clientFactory.CreateClient("API");
            await client.PutAsJsonAsync($"api/kullanicilar/{kullaniciId}/yetkiler", yetkiler);
            return RedirectToPage(new { kullaniciId });
        }

        public async Task<IActionResult> OnPostTemizleAsync(int kullaniciId)
        {
            var client = _clientFactory.CreateClient("API");

            var bosYetkiler = FormYetkileri.Keys
                .Select(f => new KullaniciYetkiDto { FormAdi = f })
                .ToList();
            await client.PutAsJsonAsync($"api/kullanicilar/{kullaniciId}/yetkiler", bosYetkiler);
            return RedirectToPage(new { kullaniciId });
        }
        public async Task<IActionResult> OnPostKopyalaAsync(int kaynakId, List<int> hedefler)
        {
            var client = _clientFactory.CreateClient("API");
            var yetkiler = await client.GetFromJsonAsync<List<KullaniciYetkiDto>>(
                $"api/kullanicilar/{kaynakId}/yetkiler") ?? new();
            foreach (var hedefId in hedefler)
            {
                await client.PutAsJsonAsync($"api/kullanicilar/{hedefId}/yetkiler", yetkiler);
            }
            return RedirectToPage(new { kullaniciId = kaynakId });
        }
    }
}
