using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StajWeb.Models;
using System.Net.Http.Json;
using System.ComponentModel.DataAnnotations;
using StajWeb.Dtos;

namespace StajWeb.Pages
{
    public class SatinAlModel : PageModel
    {
        [BindProperty] public List<YolcuDto> Yolcular { get; set; } = new();
        [BindProperty(SupportsGet = true)] public int SeferId { get; set; }
        [BindProperty(SupportsGet = true)] public string Koltuklar {  get; set; }
        public List<int> KoltukList { get; set; } = new List<int>();
        private readonly IHttpClientFactory _clientFactory;

        public SatinAlModel(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public void OnGet() {
            
            if (!string.IsNullOrEmpty(Koltuklar))
            {
                KoltukList = Koltuklar.Split(',').Select(int.Parse).ToList();
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!string.IsNullOrEmpty(Koltuklar)) 
                KoltukList = Koltuklar.Split(',').Select(int.Parse).ToList();

                if (!ModelState.IsValid) return Page();
                var client = _clientFactory.CreateClient("API");

                    for (int i = 0; i < KoltukList.Count; i++)
                    {
                        var yolcu = Yolcular[i];
                        var response = await client.PostAsJsonAsync("/api/biletler/satinal", new
                        {
                            SeferId,
                            KoltukNo = KoltukList[i],
                            yolcu.MusteriTc,
                            yolcu.MusteriAd,
                            yolcu.MusteriSoyad,
                            yolcu.MusteriMail,
                            yolcu.MusteriTelefon,
                            yolcu.MusteriSehir,
                            yolcu.MusteriAdres,
                            yolcu.MusteriCinsiyet,
                            BinisDurakSira = 1,
                            InisDurakSira = 1
                        });
                        if (response.StatusCode == System.Net.HttpStatusCode.Conflict)
                            return Page();
                        if (!response.IsSuccessStatusCode)
                            return Page();
                    }
                    return RedirectToPage("/Index");
        }
    }
}