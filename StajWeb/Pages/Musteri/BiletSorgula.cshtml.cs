using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StajWeb.Models;
using System.Net.Http.Json;
using StajWeb.Dtos;

namespace StajWeb.Pages
{
    public class BiletSorgulaModel : PageModel
    {
        [BindProperty] public string MusteriTc { get; set; } = "";

        public List<BiletDto> Biletler { get; set; } = new List<BiletDto>();

        private readonly IHttpClientFactory _clientFactory;

        public BiletSorgulaModel(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (string.IsNullOrWhiteSpace(MusteriTc))
            {
                ModelState.AddModelError("MusteriTc", "TC kimlik numarası boş olamaz.");
                return Page();
            }

            var client = _clientFactory.CreateClient("API");
            var response = await client.GetAsync($"/api/biletler/musteri/{MusteriTc}");

            if (response.IsSuccessStatusCode)
                Biletler = await response.Content.ReadFromJsonAsync<List<BiletDto>>() ?? new();
            else
                ModelState.AddModelError("", "Bilet bulunamadı veya geçersiz TC.");

            return Page();
        }
    }
}