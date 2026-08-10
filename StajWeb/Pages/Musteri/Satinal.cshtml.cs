using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StajWeb.Dtos;
using StajWeb.Models;
using System.Net.Http.Json;

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
        public List<string> SehirListesi { get; set; } = new();
        public string? HataMesaji { get; set; }
        private readonly IHttpClientFactory _clientFactory;

        public SatinAlModel(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task OnGet() {
            
            if (!string.IsNullOrEmpty(Koltuklar))
            {
                KoltukList = Koltuklar.Split(',').Select(int.Parse).ToList();
            }

            var client = _clientFactory.CreateClient("API");
            SehirListesi = await client.GetFromJsonAsync<List<Sehirler>>("/api/sehirler")
                is { } list ? list.Select(s => s.SehirAdi).ToList() : new();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!string.IsNullOrEmpty(Koltuklar)) 
                KoltukList = Koltuklar.Split(',').Select(int.Parse).ToList();

            var client = _clientFactory.CreateClient("API");
            SehirListesi = await client.GetFromJsonAsync<List<Sehirler>>("/api/sehirler")
                is { } list ? list.Select(s => s.SehirAdi).ToList() : new();

                if (!ModelState.IsValid) return Page();

                foreach (var yolcu in Yolcular)
                {
                    var tc = yolcu.MusteriTc?.Trim() ?? "";
                    if (!TcGecerliMi(tc))
                    {
                        HataMesaji = "Hatalı TC Kimlik Numarası girişi yapıldı.";
                        return Page();
                    }
                    var tel = yolcu.MusteriTelefon?.Trim() ?? "";
                    if (tel.Length != 11 || tel[0] != '0' || !tel.All(char.IsDigit))
                    {
                        HataMesaji = "Telefon numarası 11 haneli olmalı, 0 ile başlamalı ve sadece rakamlardan oluşmalıdır.";
                        return Page();
                    }
                }

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

            return RedirectToPage("/Musteri/Seferler");

        }

        private static bool TcGecerliMi(string tc)
        {
            if (string.IsNullOrEmpty(tc) || tc.Length != 11 || tc[0] == '0' || !tc.All(char.IsDigit))
                return false;

            int[] h = tc.Select(c => c - '0').ToArray();
            int hane10 = ((h[0] + h[2] + h[4] + h[6] + h[8]) * 7 - (h[1] + h[3] + h[5] + h[7])) % 10;
            if (hane10 < 0) hane10 += 10;
            return hane10 == h[9] && h.Take(10).Sum() % 10 == h[10];
        }
    }
}