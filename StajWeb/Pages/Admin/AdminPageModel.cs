using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Filters;
using StajWeb.Helpers;

namespace StajWeb.Pages.Admin
{
    public class AdminPageModel : PageModel
    {
        public override void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {

            if (!HttpContext.Session.GirisliMi())
            {
                context.Result = RedirectToPage("/Admin/Login");
                return;
            }
            base.OnPageHandlerExecuting(context);
        }
    }
}
