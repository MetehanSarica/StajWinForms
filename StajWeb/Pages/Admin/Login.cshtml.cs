using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StajWeb.Dtos;
using StajWeb.Helpers;
using System.Net.Http.Json;

namespace StajWeb.Pages.Admin
{
    public class LoginModel : PageModel
    {
        [BindProperty] public string KullaniciAdi { get; set; } = "";
        [BindProperty] public string Sifre { get; set; } = "";
        public string? HataMesaji { get; set; }

        private readonly IHttpClientFactory _clientFactory;
        public LoginModel(IHttpClientFactory clientFactory) => _clientFactory = clientFactory;
        public void OnGet() { }

        public async Task<IActionResult> OnPostAsync()
        {
            var client = _clientFactory.CreateClient("API");
            var response = await client.PostAsJsonAsync("api/auth/login",
                new LoginDto { KullaniciAdi = KullaniciAdi, Sifre = Sifre });

            if (!response.IsSuccessStatusCode)
            {
                HataMesaji = await response.Content.ReadAsStringAsync();
                return Page();
            }

            var sonuc = await response.Content.ReadFromJsonAsync<LoginSonucDto>();
            HttpContext.Session.GirisYap(sonuc!);
            return RedirectToPage("/Admin/Index");
        }
    }
}