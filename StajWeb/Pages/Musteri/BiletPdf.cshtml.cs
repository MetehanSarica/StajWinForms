using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StajWeb.Dtos;
using StajWeb.Helpers;
using System.Net.Http.Json;
using System.Text.Json;

namespace StajWeb.Pages.Musteri
{
    public class BiletPdfModel : PageModel
    {
        private readonly IHttpClientFactory _clientFactory;
        public BiletPdfModel(IHttpClientFactory clientFactory) => _clientFactory = clientFactory;

        public List<int> BiletIdler { get; set; } = new();

        public IActionResult OnGet()
        {
            var json = TempData["BiletIdler"] as string;
            if (string.IsNullOrEmpty(json)) return RedirectToPage("/Musteri/Seferler");
            BiletIdler = JsonSerializer.Deserialize<List<int>>(json) ?? new();
            return Page();
        }

        public async Task<IActionResult> OnGetDownloadAsync(int biletId)
        {
            var client = _clientFactory.CreateClient("API");
            var detay = await client.GetFromJsonAsync<BiletDetayDto>($"api/biletler/detay/{biletId}");
            if (detay == null) return NotFound();

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
                kalkisZamani: detay.KalkisZamani,
                satinAlmaTarihi: detay.SatinAlmaTarihi
            );
            return File(pdf, "application/pdf", $"Bilet_{detay.KoltukNo}.pdf");
        }
    }
}
