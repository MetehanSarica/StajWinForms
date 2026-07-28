using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StajWeb.Models;
using System.Net.Http.Json;

namespace StajWeb.Pages;

public class IndexModel : PageModel
{
    public List<Sehirler> Sehirler { get; set; } = new List<Sehirler>();

    private readonly IHttpClientFactory _clientFactory;

    public SelectList SehirListesi {  get; set; }
    public IndexModel(IHttpClientFactory clientFactory)
    {
        _clientFactory = clientFactory;
    }

    public async Task OnGetAsync()
    {
        var client = _clientFactory.CreateClient("API");
        Sehirler = await client.GetFromJsonAsync<List<Sehirler>>("/api/sehirler") ?? new();
        SehirListesi = new SelectList(Sehirler, "SehirId", "SehirAdi");
    }
}
