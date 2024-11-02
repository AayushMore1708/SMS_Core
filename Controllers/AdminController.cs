using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SMS_Core.Models;
using SMS_Core.ViewModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;


namespace SMS_Core.Controllers
{
    public class AdminController : Controller
    {
        private readonly SMSDbContext _context;

        // Inject DbContext through constructor
        public AdminController(SMSDbContext db)
        {
            _context = db;
        }

        //Notes for Syllabus

        public ActionResult Notes()
        {
            var lp = _context.tblAssignmentNotes.ToList();
            return View("../Admin/Notes", lp);
        }
        [HttpGet]
        public IActionResult ViewAssignments()
        {
            var Assignments = _context.tblAssignment.ToList(); // Fetch all academic years
            return View("../Admin/Assignement", Assignments); // Pass the list to the view
        }
        public ActionResult AssignementNew()
        {
            ViewBag.crc = _context.tblAcadamicCource;
            ViewBag.bat = _context.tblCourseBatch;
            ViewBag.sbu = _context.tblSubject;

            return View("../Admin/AssignementNew");
        }

        [HttpPost]
        public async Task<ActionResult> AssignmentNew(tblAssignmentNote asbu, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                string fname = "";
                if (file != null && file.Length > 0)
                {
                    var filename = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Content/Upload", filename);

                    // Save the file to the specified path
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }

                    fname = filename;
                }

                asbu.NotesUpload = fname;
                var ayr = _context.tblAcadamicYear
                            .Where(x => x.AcadamicStatus == "Started")
                            .Select(x => x.AcadamicYear)
                            .FirstOrDefault();

                asbu.AcadamicYear = ayr;
                _context.tblAssignmentNotes.Add(asbu);
                await _context.SaveChangesAsync();
                return RedirectToAction("../Admin/Assignement");
            }

            ViewBag.crc = _context.tblAcadamicCource;
            ViewBag.bat = _context.tblCourseBatch;
            ViewBag.sbu = _context.tblSubject;

            return View(asbu);
        }

        [HttpGet]
        public IActionResult LessonPlanning()
        {
            var lp = _context.tblLessonPlanning.ToList();
            return View("../admin/LessonPlanning", lp);
        }
        public ActionResult LessonPlanningNew()
        {
            ViewBag.crc = _context.tblAcadamicCource;
            ViewBag.bat = _context.tblCourseBatch;
            ViewBag.sbu = _context.tblSubject;

            int lpn = _context.tblAutoIncrement.Max(x => (Int32?)x.lessonPlanningId) ?? 0;
            if (lpn == 0)
            {
                lpn = 1;
            }
            else
            {
                lpn = lpn + 1;
            }

            ViewBag.lpn = lpn;

            tblAutoIncrement ai = _context.tblAutoIncrement.Find(2);
            ai.lessonPlanningId = lpn;
            var ayr = _context.tblAcadamicYear.Where(x => x.AcadamicStatus == "Started").Select(x => x.AcadamicYear).FirstOrDefault();
            ai.AcadamicYear = ayr;
            _context.Entry(ai).State = EntityState.Modified;
            _context.SaveChanges();

   
            return View("../Admin/LessonPlanningNew");
        }



        public ActionResult NotesEdit(int id)
        {
            ViewBag.crc = _context.tblAcadamicCource;
            ViewBag.bat = _context.tblCourseBatch;
            ViewBag.sbu = _context.tblSubject;

            var ae = _context.tblAssignmentNotes.Find(id);

            return View(ae);
        }

        [HttpPost]
        public ActionResult NotesEdit(tblAssignmentNote asbu)
        {
            if (ModelState.IsValid)
            {
                var ayr = _context.tblAcadamicYear.Where(x => x.AcadamicStatus == "Started").Select(x => x.AcadamicYear).FirstOrDefault();
                asbu.AcadamicYear = ayr;
                _context.Entry(asbu).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Notes");
            }
            ViewBag.crc = _context.tblAcadamicCource;
            ViewBag.bat = _context.tblCourseBatch;
            ViewBag.sbu = _context.tblSubject;

            return View(asbu);
        }


        //Notes for Syllabus end


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

            return View("../Main/EmployeeIndexDash", employees);
        }

    }
}
