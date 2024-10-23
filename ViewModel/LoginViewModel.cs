using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using SMS_Core.Models;

namespace SMS.ViewModel
{
    public class LoginViewModel : PageModel
    {
        public class LoginViewModels : PageModel
        {
            [BindProperty]
            public Models.LoginModel LoginViewModesl { get; set; }

            public List<SelectListItem> AcademicYears { get; set; }

            public void OnGet()
            {
                AcademicYears = new List<SelectListItem>
        {
            new SelectListItem { Text = "2021", Value = "2021" },
            new SelectListItem { Text = "2022", Value = "2022" },
            new SelectListItem { Text = "2023", Value = "2023" }
        };
            }

            public IActionResult OnPost()
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }

                // Perform authentication logic here
                if (LoginViewModesl.UsernName == "123" && LoginViewModesl.Password == "456")
                {
                    // Redirect to a new page upon successful login
                    return RedirectToPage("/Dashboard");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password");
                    return Page();
                }
            }
        }
    }
}
