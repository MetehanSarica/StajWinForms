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
            Yetki = HttpContext.Session.GetYetki("btnSeferBrowser");
            var client = _clientFactory.CreateClient("API");
            Seferler = await client.GetFromJsonAsync<List<SeferDto>>("api/seferler") ?? new();
            Firmalar = await client.GetFromJsonAsync<List<FirmaDto>>("api/firmalar") ?? new();
            Sehirler = await client.GetFromJsonAsync<List<Sehirler>>("api/sehirler") ?? new();
        }

        public async Task<IActionResult> OnPostEkleAsync()
        {
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

        public async Task<IActionResult> OnPostSilAsync(int seferId)
        {
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
