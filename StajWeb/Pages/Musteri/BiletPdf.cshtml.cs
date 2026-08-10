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

        public async Task<IActionResult> OnGetAsync()
        {
            var json = TempData["BiletIdler"] as string;
            if (string.IsNullOrEmpty(json))
                return RedirectToPage("/Index");

            var biletIdler = JsonSerializer.Deserialize<List<int>>(json) ?? new();
            var client = _clientFactory.CreateClient("API");

            var detaylar = new List<BiletDetayDto>();
            foreach(var id in biletIdler)
            {
                var detay = await client.GetFromJsonAsync<BiletDetayDto>($"api/biletler/detay/{id}");
                if (detay != null) detaylar.Add(detay);
            }

            if (detaylar.Count == 0)
                return RedirectToPage("/Index");

            var pdf = BiletPdfHelper.OlusturCoklu(detaylar);
            return File(pdf, "application/pdf", "Biletler.pdf");
        }
    }
}
