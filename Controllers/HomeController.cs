using Microsoft.AspNetCore.Mvc;
using SMS.Models;
using SMS.ViewModel; // Import the namespace for LoginViewModel

namespace SMS.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            LoginModel model = new LoginModel();
            return View(model);
        }



        [HttpPost]
        public IActionResult Index(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                if (model.UsernName == "a" && model.Password == "a")
                {
                    // Login successful, return JSON response
                    return RedirectToAction("GridButtonMenu", "Home");
                }
                else
                {
                    // Login failed, return JSON response
                    return Json(new { success = false, message = "Invalid username or password" });
                }
            }
            else
            {
                // Model state is invalid, return JSON response
                return Json(new { success = false, message = "Invalid model state" });
            }
        }

        [HttpGet]
        public IActionResult GridButtonMenu()
        {
            // Return the grid view
            return View("GridButtonMenu");
        }
    }
}