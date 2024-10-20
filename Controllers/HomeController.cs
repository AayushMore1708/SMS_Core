using Microsoft.AspNetCore.Mvc;
using SMS.Models;
using SMS.ViewModel;
using SMS_Core.Models; // Import the namespace for LoginViewModel

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

        private readonly SMSDbContext _context;

        public HomeController(SMSDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Index(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                if (model.UsernName == "AayushMore1722@gmail.com" && model.Password == "17082003Aa@#123123123")
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


        [HttpGet]
        public IActionResult ViewStudData()
        {
            // Fetch the list of students from the database
            var students = _context.Students.ToList();

            // Return the "StudentsView" and pass the list of students as the model
            return View("StudentsView", students);
        }
        [HttpGet]
        public IActionResult AddStudent()
        {
            // Return the "AddStudent" view
            return View("AddStudents");
        }


        [HttpGet]
        public IActionResult EditStudent(int id)
        {
            // Find the student by ID
            var student = _context.Students.FirstOrDefault(s => s.ID == id);

            if (student == null)
            {
                // Handle case where student is not found
                return NotFound();
            }

            // Pass the student data to the view for editing
            return View("EditStudents", student);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteStudent(int id)
        {
            var student = _context.Students.FirstOrDefault(s => s.ID == id);

            if (student == null)
            {
                return NotFound(); // Handle if student not found
            }

            _context.Students.Remove(student);
            _context.SaveChanges();

            return RedirectToAction("ViewStudData");
        }


        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            // Add the student to the database
            _context.Students.Add(student);
            _context.SaveChanges();

            // Redirect to the "ViewStudData" action
            return RedirectToAction("ViewStudData");
        }
        [HttpPost]
        public IActionResult EditStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                // Update the student in the database
                var existingStudent = _context.Students.FirstOrDefault(s => s.ID == student.ID);
                if (existingStudent != null)
                {
                    existingStudent.Name = student.Name;
                    existingStudent.Age = student.Age;
                    existingStudent.Grade = student.Grade;

                    _context.SaveChanges();
                    return RedirectToAction("ViewStudData");
                }

                return NotFound(); // Handle if student not found
            }

            // If model state is invalid, return the same view with the current data
            return View("EditStudents", student);
        }


    }
}