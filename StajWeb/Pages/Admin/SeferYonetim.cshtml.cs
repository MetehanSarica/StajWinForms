using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StajWeb.Dtos;
using StajWeb.Helpers;
using StajWeb.Models;
using System.Net.Http.Json;

namespace StajWeb.Pages.Admin
{
    public class SeferYonetimModel : AdminPageModel
    {
        private readonly IHttpClientFactory _clientFactory;
        public SeferYonetimModel(IHttpClientFactory clientFactory) => _clientFactory = clientFactory;

        public List<SeferDto> Seferler { get; set; } = new();
        public List<FirmaDto> Firmalar { get; set; } = new();
        public List<Sehirler> Sehirler { get; set; } = new();
        public KullaniciYetkiDto? Yetki { get; set; }


        public async Task OnGetAsync()
        {
            Yetki = HttpContext.Session.GetYetki("sefer_yonetimi");
            var client = _clientFactory.CreateClient("API");
            Seferler = await client.GetFromJsonAsync<List<SeferDto>>("api/seferler") ?? new();
            Firmalar = await client.GetFromJsonAsync<List<FirmaDto>>("api/firmalar") ?? new();
            Sehirler = await client.GetFromJsonAsync<List<Sehirler>>("api/sehirler") ?? new();
        }

        public async Task<IActionResult> OnPostEkleAsync()
        {
            if (HttpContext.Session.GetYetki("sefer_yonetimi")?.Ekle != true) return Forbid();
            var form = Request.Form;
            var sefer = new SeferDto
            {
                FirmaId = int.Parse(form["FirmaId"]!),
                KalkisSehirId = int.Parse(form["KalkisSehirId"]!),
                VarisSehirId = int.Parse(form["VarisSehirId"]!),
                KalkisZamani = DateTime.Parse(form["KalkisZamani"]!),
                SureDakika = int.Parse(form["SureDakika"]!),
                Fiyat = decimal.Parse(form["Fiyat"]!, System.Globalization.CultureInfo.InvariantCulture),
                KoltukKapasitesi = int.Parse(form["KoltukKapasitesi"]!)
            };
            var client = _clientFactory.CreateClient("API");
            var response = await client.PostAsJsonAsync("api/seferler", sefer);
            if (response.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "Sefer başarıyla eklendi.";
            }
            else
            {
                TempData["ErrorMessage"] = "Sefer eklenirken bir hata oluştu.";
            }
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostDuzenleAsync()
        {
            if (HttpContext.Session.GetYetki("sefer_yonetimi")?.Degistir != true) return Forbid();
            var form = Request.Form;
            var sefer = new SeferDto
            {
                SeferId = int.Parse(form["SeferId"]!),
                FirmaId = int.Parse(form["FirmaId"]!),
                KalkisSehirId = int.Parse(form["KalkisSehirId"]!),
                VarisSehirId = int.Parse(form["VarisSehirId"]!),
                KalkisZamani = DateTime.Parse(form["KalkisZamani"]!),
                SureDakika = int.Parse(form["SureDakika"]!),
                Fiyat = decimal.Parse(form["Fiyat"]!, System.Globalization.CultureInfo.InvariantCulture),
                KoltukKapasitesi = int.Parse(form["KoltukKapasitesi"]!)
            };
            var client = _clientFactory.CreateClient("API");
            var response = await client.PutAsJsonAsync($"api/seferler/{sefer.SeferId}", sefer);
            if (response.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "Sefer başarıyla güncellendi.";
            }
            else
            {
                TempData["ErrorMessage"] = "Sefer güncellenirken bir hata oluştu.";
            }
            return RedirectToPage();
        }

        public async Task<IActionResult> OnGetYolcularAsync(int seferId)
        {
            var client = _clientFactory.CreateClient("API");
            var yolcular = await client.GetFromJsonAsync<List<YolcuListesiDto>>($"api/biletler/{seferId}") ?? new();
            return new JsonResult(yolcular);
        }

        public async Task<IActionResult> OnPostIptalAsync(int seferId)
        {
            if (HttpContext.Session.GetYetki("sefer_yonetimi")?.AktifPasif != true) return Forbid();
            var client = _clientFactory.CreateClient("API");
            await client.PutAsync($"api/seferler/{seferId}/iptal", null);
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostAktifEtAsync(int seferId)
        {
            if (HttpContext.Session.GetYetki("sefer_yonetimi")?.AktifPasif != true) return Forbid();
            var client = _clientFactory.CreateClient("API");
            await client.PutAsync($"api/seferler/{seferId}/aktifet", null);
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostSilAsync(int seferId)
        {
            if (HttpContext.Session.GetYetki("sefer_yonetimi")?.Sil != true) return Forbid();
            var client = _clientFactory.CreateClient("API");
            var response = await client.DeleteAsync($"api/seferler/{seferId}");
            if (response.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "Sefer başarıyla silindi.";
            }
            else
            {
                TempData["ErrorMessage"] = "Sefer silinirken bir hata oluştu.";
            }
            return RedirectToPage();
        }
    }
}
