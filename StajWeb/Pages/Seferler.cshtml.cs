using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StajWeb.Models;
using System.Net.Http.Json;

namespace StajWeb.Pages
{
    public class SeferlerModel : PageModel
    {
        public SeferlerModel(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public List<SeferDetay> Seferler { get; set; }
        
        private readonly IHttpClientFactory _clientFactory;

        public async Task OnGetAsync(int? kalkisId, int? varisId, DateTime? tarih)
        {
            var client = _clientFactory.CreateClient("API");
            Seferler = await client.GetFromJsonAsync<List<SeferDetay>>("/api/seferdetay") ?? new();

            if (kalkisId.HasValue && varisId.HasValue && tarih.HasValue)
            { 
            Seferler = Seferler
                .Where(s => s.KalkisZamani.Date == tarih.Value.Date
                && s.KalkisSehirId == kalkisId.Value
                && s.VarisSehirId == varisId.Value)
                .ToList();
            }
        }
    }
}
