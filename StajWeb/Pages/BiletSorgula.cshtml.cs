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
        [BindProperty] public string MusteriTc { get; set; }

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
            var client = _clientFactory.CreateClient("API");
            Biletler = await client.GetFromJsonAsync<List<BiletDto>>($"/api/biletler/musteri/{MusteriTc}");
            return Page();
        }
    }
}