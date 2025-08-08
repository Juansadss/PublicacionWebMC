using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Publicacion_WebMC.Pages

{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Password { get; set; }
        public string Message { get; set; }

        public IActionResult OnPost()
        {
            // Credenciales hardcodeadas
            if (Username == "admin" && Password == "1234")
            {
                TempData["User"] = Username;
                return RedirectToPage("/Home");
            }

            Message = "Usuario o contraseña incorrectos.";
            return Page();
        }
    }
}
