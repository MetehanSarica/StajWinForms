using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StajWeb.Dtos;
using StajWeb.Models;
using System.Net.Http.Json;

namespace StajWeb.Pages
{
    public class SeferlerModel : PageModel
    {
        private readonly IHttpClientFactory _clientFactory;
        public SeferlerModel(IHttpClientFactory clientFactory) => _clientFactory = clientFactory;

        [BindProperty(SupportsGet = true)] public int? KalkisId { get; set; }
        [BindProperty(SupportsGet = true)] public int? VarisId { get; set; }
        [BindProperty(SupportsGet = true)] public DateTime? Tarih { get; set; }
        [BindProperty(SupportsGet = true)] public int? ExpandId { get; set; }
        [BindProperty(SupportsGet = true)] public int? Binis { get; set; }
        [BindProperty(SupportsGet = true)] public int? Inis { get; set; }

        public List<SeferDetay> Seferler { get; set; } = new();
        public SeferDetay? SeciliSefer { get; set; }
        public List<Bilet> Biletler { get; set; } = new();
        public List<DurakDto> Duraklar { get; set; } = new();

        public async Task OnGetAsync()
        {
            var client = _clientFactory.CreateClient("API");
            Seferler = await client.GetFromJsonAsync<List<SeferDetay>>("/api/seferdetay") ?? new();

            if (KalkisId.HasValue && VarisId.HasValue && Tarih.HasValue)
                Seferler = Seferler.Where(s =>
                    s.KalkisZamani.Date == Tarih.Value.Date &&
                    s.KalkisSehirId == KalkisId.Value &&
                    s.VarisSehirId == VarisId.Value).ToList();

            if (ExpandId.HasValue)
            {
                SeciliSefer = Seferler.FirstOrDefault(s => s.SeferId == ExpandId.Value);
                if (SeciliSefer != null)
                {
                    Biletler = await client.GetFromJsonAsync<List<Bilet>>($"/api/biletler/{ExpandId.Value}") ?? new();
                    Duraklar = await client.GetFromJsonAsync<List<DurakDto>>($"/api/seferduraklar/{ExpandId.Value}") ?? new();
                    Binis ??= Duraklar.FirstOrDefault()?.DurakSira;
                    Inis ??= Duraklar.LastOrDefault()?.DurakSira;
                    if (Binis >= Inis)
                    {
                        Binis = Duraklar.First().DurakSira;
                        Inis = Duraklar.Last().DurakSira;
                    }
                }
            }
        }
    }
}