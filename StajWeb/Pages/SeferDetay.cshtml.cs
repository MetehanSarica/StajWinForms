using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StajWeb.Dtos;
using StajWeb.Models;
using System.Net.Http.Json;

namespace StajWeb.Pages
{
    public class SeferDetayModel : PageModel
    {
        [BindProperty(SupportsGet = true)] public int Id { get; set; }
        [BindProperty(SupportsGet = true)] public int? Binis { get; set; }
        [BindProperty(SupportsGet = true)] public int? Inis { get; set; }
        public List<DurakDto> Duraklar { get; set; } = new();
        public SeferDetay Sefer {  get; set; }

        public List<Bilet> Biletler { get; set; } = new List<Bilet>();
        
        private readonly IHttpClientFactory _clientFactory;
        
        public SeferDetayModel(IHttpClientFactory clientFactory)
        
        {
            _clientFactory = clientFactory;
        }

        public async Task OnGetAsync()
        {
            var client = _clientFactory.CreateClient("API");
            Sefer = await client.GetFromJsonAsync<SeferDetay>($"/api/seferdetay/{Id}");
            Biletler = await client.GetFromJsonAsync<List<Bilet>>($"/api/biletler/{Id}");

            Duraklar = await client.GetFromJsonAsync<List<DurakDto>>($"/api/seferduraklar/{Id}");
            Binis ??= Duraklar.First().DurakSira;
            Inis ??= Duraklar.Last().DurakSira;
            if (Binis >= Inis)
            {
                Binis = Duraklar.First().DurakSira;
                Inis = Duraklar.Last().DurakSira;
            }
        }
    }
}
