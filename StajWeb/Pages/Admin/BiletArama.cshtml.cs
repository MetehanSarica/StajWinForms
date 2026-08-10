using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StajWeb.Dtos;
using StajWeb.Helpers;
using StajWeb.Models;
using System.Net.Http.Json;

namespace StajWeb.Pages.Admin
{
    public class BiletAramaModel : AdminPageModel
    {
        private readonly IHttpClientFactory _clientFactory;
        public BiletAramaModel(IHttpClientFactory clientFactory) => _clientFactory = clientFactory;

        public List<BiletDto> Biletler { get; set; } = new();
        public KullaniciYetkiDto? Yetki { get; set; }
        public List<Sehirler> Sehirler { get; set; } = new List<Sehirler>();

        [BindProperty(SupportsGet = true)]public int KalkisId { get; set; }
        [BindProperty(SupportsGet = true)]public int VarisId { get; set; }
        [BindProperty(SupportsGet = true)]public string? Tarih { get; set; }


        public async Task OnGetAsync()
        {
            Yetki = HttpContext.Session.GetYetki("btnBiletArama");
            var client = _clientFactory.CreateClient("API");
            Sehirler = await client.GetFromJsonAsync<List<Sehirler>>("api/sehirler") ?? new();

            var parts = new List<string>();
            if (KalkisId > 0) parts.Add($"kalkisId={KalkisId}");
            if (VarisId > 0) parts.Add($"varisId={VarisId}");
            if (!string.IsNullOrEmpty(Tarih)) parts.Add($"tarih={Tarih}");

            var url = "api/biletler/ara" + (parts.Count > 0 ? "?" + string.Join("&", parts) : "");
            Biletler = await client.GetFromJsonAsync<List<BiletDto>>(url) ?? new();
        }

        public async Task<IActionResult> OnGetPdfAsync(int biletId)
        {
            var client = _clientFactory.CreateClient("API");
            var detay = await client.GetFromJsonAsync<BiletDetayDto>($"api/biletler/detay/{biletId}");
            
            if (detay == null)
                return NotFound();

            var pdf = BiletPdfHelper.Olustur(
                adSoyad: $"{detay.MusteriAd} {detay.MusteriSoyad}",
                tc: detay.MusteriTc,
                telefon: detay.MusteriTelefon,
                email: detay.MusteriEmail,
                sehir: detay.MusteriSehir,
                cinsiyet: detay.Cinsiyet,
                adres: detay.MusteriAdres,
                koltukNo: detay.KoltukNo,
                seferNo: detay.SeferId,
                kalkisSehir: detay.KalkisSehirAdi,
                varisSehir: detay.VarisSehirAdi,
                kalkisZamani: detay.KalkisZamani
                );

            return File(pdf, "application/pdf", $"Bilet_{detay.MusteriTc}_{detay.KoltukNo}.pdf");

        }
    }
}
