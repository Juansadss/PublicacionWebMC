using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Publicacion_WebMC.Pages

{
    public class HomeModel : PageModel
    {
        public string Username { get; set; }

        public IActionResult OnGet()
        {
            if (TempData["User"] == null)
            {
                return RedirectToPage("/Login");
            }

            Username = TempData["User"].ToString();
            return Page();
        }
    }
}
