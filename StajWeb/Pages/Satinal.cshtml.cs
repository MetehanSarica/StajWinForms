using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StajWeb.Models;
using System.Net.Http.Json;
using System.ComponentModel.DataAnnotations;
using StajWeb.Dtos;
using Microsoft.Extensions.Configuration.Ini;

namespace StajWeb.Pages
{
    public class SatinAlModel : PageModel
    {
        [BindProperty] public List<YolcuDto> Yolcular { get; set; } = new();
        [BindProperty(SupportsGet = true)] public int SeferId { get; set; }
        [BindProperty(SupportsGet = true)] public string Koltuklar {  get; set; }
        [BindProperty(SupportsGet = true)] public int Binis {  get; set; }
        [BindProperty(SupportsGet = true)] public int Inis { get; set; }
        public List<int> KoltukList { get; set; } = new List<int>();
        public string? HataMesaji { get; set; }
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

                foreach (var yolcu in Yolcular)
                {
                    var tc = yolcu.MusteriTc?.Trim() ?? "";
                    if (tc.Length != 11 || tc[0] == '0' || !tc.All(char.IsDigit))
                    {
                        HataMesaji = "TC Kimlik No 11 haneli olmalı, 0 ile başlamamalı ve sadece rakamlardan oluşmalıdır.";
                        return Page();
                    }
                    var tel = yolcu.MusteriTelefon?.Trim() ?? "";
                    if (tel.Length != 11 || tel[0] != '0' || !tel.All(char.IsDigit))
                    {
                        HataMesaji = "Telefon numarası 11 haneli olmalı, 0 ile başlamalı ve sadece rakamlardan oluşmalıdır.";
                        return Page();
                    }
                }

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
                            BinisDurakSira = Binis,
                            InisDurakSira = Inis,
                        });
                        if (!response.IsSuccessStatusCode)
                        {
                            var apiMesaj = await response.Content.ReadAsStringAsync();
                            HataMesaji = string.IsNullOrWhiteSpace(apiMesaj)
                                ? "Bilet satın alınamadı. Lütfen tekrar deneyin."
                                : apiMesaj;
                            return Page();
                        }
                    }
                    return RedirectToPage("/Index");
        }
    }
}