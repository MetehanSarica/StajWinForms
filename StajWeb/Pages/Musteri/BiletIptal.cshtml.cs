using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StajWeb.Models;
using System.Net.Http.Json;
using StajWeb.Dtos;

namespace StajWeb.Pages
{
    public class BiletIptalModel : PageModel
    {
        [BindProperty(SupportsGet = true)] public string MusteriTc { get; set; } = "";
        [BindProperty(SupportsGet = true)] public int BiletId { get; set; }

        private readonly IHttpClientFactory _clientFactory;

        public BiletIptalModel(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        
        public async Task<IActionResult> OnPostAsync()
        {
            var client = _clientFactory.CreateClient("API");
            var bilet = await client.GetFromJsonAsync<BiletDetayDto>($"api/biletler/detay/{BiletId}");
            if (bilet == null || bilet.MusteriTc != MusteriTc)
                return RedirectToPage("/Musteri/BiletSorgula");

            await client.DeleteAsync($"/api/biletler/{BiletId}");
            return RedirectToPage("/Musteri/BiletSorgula");
        }
    }
}
