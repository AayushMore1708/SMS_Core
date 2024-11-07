using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SMS_Core.Models;
using SMS_Core.ViewModel; // Import the namespace for LoginViewModel

namespace SMS_Core.Controllers
{
    public class MainController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            LoginModel model = new LoginModel();
            return View(model);
        }
        [HttpGet]
        public IActionResult ViewLeaveData()
        {

            return View("Leave"); // Pass the list to the view
        }

        private readonly SMSDbContext _context;

        public MainController(SMSDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult ViewVisitorData()
        {
            var Visitors = _context.tblVisitor.ToList(); // Fetch all academic years
            return View("Visitors", Visitors); // Pass the list to the view
        }


        public ActionResult ViewEmployeeData()
        {
            // Get the academic year with status "Started"
            var ayr = _context.tblAcadamicYear
                              .Where(x => x.AcadamicStatus == "Started")
                              .Select(acyear => new
                              {
                                  Acadamic = acyear.AcadamicStartMonth + " " + acyear.AcadamicStartYear
                                          + " - " + acyear.AcadamicEndMonth + " " + acyear.AcadamicEndYear
                              })
                              .FirstOrDefault();  // Use FirstOrDefault to prevent sequence issues

            ViewBag.ay = ayr?.Acadamic ?? "No academic year found.";  // Handle null case

            // Get the current employee based on the logged-in user
            var employee = _context.qryEmployee
                                   .Where(x => x.UserName == User.Identity.Name)
                                   .FirstOrDefault();  // Use FirstOrDefault

            if (employee == null)
            {
                ViewBag.Error = "Employee not found.";
                return View("../Main/EmployeeIndexDash", new List<qryEmployee>());
            }

            var userId = employee.UserID;
            ViewBag.userid = userId;

            // Get the allowed leaves for the employee for the current academic year
            var allowedLeaves = _context.tblSalaryHD
                                        .OrderByDescending(x => x.SalaryId)
                                        .Select(x => x.AllowedLeaves)
                                        .FirstOrDefault();  // Use FirstOrDefault

            ViewBag.al = allowedLeaves;

            // Get the maximum leave taken by the employee for the current academic year
            var leaveTaken = _context.tblSalaryHD
                                     .Max(x => (int?)x.LeaveTaken) ?? 0;  // Use nullable to avoid null issues

            ViewBag.lt = leaveTaken;

            // Calculate balance leave
            double balanceLeave = (allowedLeaves ?? 0) - leaveTaken;
            ViewBag.bl = balanceLeave;

            // Get the list of employees for the view
            var employees = _context.qryEmployee
                                    .OrderByDescending(x => x.EmpCode)
                                    .ThenByDescending(x => x.FirstName)
                                    .ToList();

            return View("EmployeeIndexDash", employees);
        }

         [HttpGet]
          public IActionResult ViewSubjects()
        {
            var sub = _context.tblSubject.ToList(); // Fetch all academic years
            return View("Subject", sub); // Pass the list to the view
        }
 
    }
}