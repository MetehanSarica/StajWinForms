using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StajWeb.Models;
using System.Net.Http.Json;
using System.ComponentModel.DataAnnotations;

namespace StajWeb.Pages
{
    public class SatinAlModel : PageModel
    {
        [BindProperty(SupportsGet = true)] public int SeferId { get; set; }
        [BindProperty(SupportsGet = true)] public int KoltukNo { get; set; }

        [BindProperty, Required(ErrorMessage = "TC Kimlik No zorunludur."), StringLength(11, MinimumLength = 11, ErrorMessage = "TC Kimlik No 11 haneli olmalıdır."), RegularExpression(@"^[1-9][0-9]{10}$", ErrorMessage = "TC 11 haneli olmalı ve 0 ile başlamamalıdır.")]
        public string MusteriTc { get; set; }

        [BindProperty, Required(ErrorMessage = "Ad zorunludur.")]
        public string MusteriAd { get; set; }

        [BindProperty, Required(ErrorMessage = "Soyad zorunludur.")]
        public string MusteriSoyad { get; set; }

        [BindProperty, Required(ErrorMessage = "E-posta zorunludur."), EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        public string MusteriMail { get; set; }

        [BindProperty, Required(ErrorMessage = "Telefon zorunludur."), StringLength(11, MinimumLength = 11, ErrorMessage = "Telefon 11 haneli olmalıdır."), RegularExpression(@"^0[0-9]{10}$", ErrorMessage = "Telefon 0 ile başlamalı ve 11 haneli olmalıdır.")]
        public string MusteriTelefon { get; set; }

        [BindProperty, Required(ErrorMessage = "Şehir zorunludur.")]
        public string MusteriSehir { get; set; }

        [BindProperty, Required(ErrorMessage = "Adres zorunludur.")]
        public string MusteriAdres { get; set; }

        [BindProperty, Required(ErrorMessage = "Cinsiyet zorunludur.")]
        public string MusteriCinsiyet { get; set; }

        private readonly IHttpClientFactory _clientFactory;

        public SatinAlModel(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public void OnGet() { }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();
            var client = _clientFactory.CreateClient("API");
            var response = await client.PostAsJsonAsync("/api/biletler/satinal", new
            {
                SeferId,
                KoltukNo,
                MusteriTc,
                MusteriAd,
                MusteriSoyad,
                MusteriMail,
                MusteriTelefon,
                MusteriSehir,
                MusteriAdres,
                MusteriCinsiyet,
                BinisDurakSira = 1,
                InisDurakSira = 1,
            });
            if (response.IsSuccessStatusCode)
            {
                return RedirectToPage("/Index");
            }
            return Page();
        }


    }
}
