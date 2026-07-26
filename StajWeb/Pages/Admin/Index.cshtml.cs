using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StajWeb.Dtos;
using StajWeb.Helpers;

namespace StajWeb.Pages.Admin
{
    public class IndexModel : AdminPageModel
    {
        public LoginSonucDto Oturum { get; set; } = null!;

        public void OnGet() => Oturum = HttpContext.Session.GetOturum()!;
        
        public IActionResult OnPostCikis()
        {
            HttpContext.Session.Clear();
            return RedirectToPage("/Admin/Login");
        }
    }
}
