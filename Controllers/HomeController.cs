using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SMS_Core.Models;
using SMS_Core.ViewModel; // Import the namespace for LoginViewModel

namespace SMS_Core.Controllers
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



        //All Views : -
        [HttpGet]
        public IActionResult ViewLibrary() => View("ViewLibrary");

        [HttpGet]
        public IActionResult GridButtonMenu() => View("GridButtonMenu");

        [HttpGet]
        public IActionResult ViewTimeTable()
        {
            var timeTableData = _context.tblTimeTableHD.ToList(); // Fetch the data
            return View("../Main/Index"); // Path to the view file
        }



        public IActionResult NotFound()
        {
            return View(); // This will return the NotFound.cshtml view
        }


        [HttpGet]
        public IActionResult ViewFeeData()
        {
            return View("x");
        }

        [HttpGet]
        public async Task<IActionResult> ViewStudData(int page = 1, int pageSize = 200) // Default page size set to 5
        {
            if (page < 1) page = 1; // Ensure valid page number

            // Get total number of students
            var totalStudents = await _context.tblStudentAdmission.CountAsync();

            // Fetch students for the current page
            var students = await _context.tblStudentAdmission
                .OrderBy(s => s.StudentAdmissionId) // Ensure consistent ordering
                .Skip((page - 1) * pageSize) // Skip previous pages
                .Take(pageSize) // Take only the required page size (5)
                .ToListAsync();

            // Prepare the view model
            var viewModel = new StudentListViewModel
            {
                Students = students,
                TotalStudents = totalStudents,
                CurrentPage = page,
                PageSize = pageSize
            };

            return View("StudentsView", viewModel); // Render the StudentsView with the ViewModel
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
            var student = _context.tblStudentAdmission.FirstOrDefault(s => s.StudentAdmissionId == id);

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
            var student = _context.tblStudentAdmission.FirstOrDefault(s => s.StudentAdmissionId == id);

            if (student == null)
            {
                return NotFound(); // Handle if student not found
            }

            _context.tblStudentAdmission.Remove(student);
            _context.SaveChanges();

            return RedirectToAction("ViewStudData");
        }


        [HttpPost]
        public IActionResult AddStudent(tblStudentAdmission student)
        {
            // Add the student to the database
            _context.tblStudentAdmission.Add(student);
            _context.SaveChanges();

            // Redirect to the "ViewStudData" action
            return RedirectToAction("ViewStudData");
        }
        // [HttpPost]
        // public IActionResult EditStudent(Student student)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         // Update the student in the database
        //         var existingStudent = _context.tblStudentAdmission.FirstOrDefault(s => s.StudentAdmissionId == student.ID);
        //         if (existingStudent != null)
        //         {
        //             existingStudent.St = student.Name;
        //             existingStudent.Age = student.Age;
        //             existingStudent.Grade = student.Grade;

        //             _context.SaveChanges();
        //             return RedirectToAction("ViewStudData");
        //         }

        //         return NotFound(); // Handle if student not found
        //     }

        //     // If model state is invalid, return the same view with the current data
        //     return View("EditStudents", student);
        // }


    }
}