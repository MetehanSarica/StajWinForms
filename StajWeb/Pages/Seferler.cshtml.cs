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

        public async Task OnGetAsync(int kalkisId, int varisId, DateTime tarih)
        {
            var client = _clientFactory.CreateClient("API");
            Seferler = await client.GetFromJsonAsync<List<SeferDetay>>("/api/seferdetay");
            Seferler = Seferler
                .Where(s => s.KalkisZamani.Date == tarih.Date
                && s.KalkisSehirId == kalkisId
                && s.VarisSehirId == varisId)
                .ToList();
        }
    }
}
