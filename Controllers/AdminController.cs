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
            return View("Notes", lp);
        }
        [HttpGet]
        public IActionResult ViewAssignments()
        {
            var Assignments = _context.tblAssignment.ToList(); // Fetch all academic years
            return View("Assignement", Assignments); // Pass the list to the view
        }
        public ActionResult AssignementNew()
        {
            ViewBag.crc = _context.tblAcadamicCource;
            ViewBag.bat = _context.tblCourseBatch;
            ViewBag.sbu = _context.tblSubject;

            return View("../Admin/AssignementNew");
        }
        [HttpGet]
        public IActionResult ViewCourses() => View("CourcesNew");
        [HttpGet]
          public IActionResult ViewBatches()
        {
            var batches = _context.tblCourseBatch.ToList(); // Fetch all academic years
            return View("Batches", batches); // Pass the list to the view
        }

         [HttpGet]
          public IActionResult ViewEmpAtt()
        {
            var empatt = _context.qryEmployee.ToList(); // Fetch all academic years
            return View("Employee", empatt); // Pass the list to the view
        }

          [HttpGet]
          public IActionResult ViewFeeData()
        {
            var fee = _context.qryFeeSubCategory.ToList(); // Fetch all academic years
            return View("Fee", fee); // Pass the list to the view
        }

         [HttpGet]
          public IActionResult ViewAttendance()
        {
            return View("AttendanceNew"); // Pass the list to the view
        }


        [HttpGet] 
        public IActionResult ViewAcademicYear()
        {
            var academicYears = _context.tblAcadamicYear.ToList(); // Fetch all academic years
            return View("AcadamicYear", academicYears); // Looks in `Views/Home/AcadamicYear.cshtml`
        }
        [HttpGet]
        public IActionResult ViewInstituteData()
        {
            var institute = _context.tblInstitute.FirstOrDefault(i => i.InstituteId == 1);
            if (institute == null)
            {
                return NotFound(); // Handle case if institute is not found
            }
            return View("Institute", institute); // Pass the institute to the view
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
            return View("LessonPlanning", lp);
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


            return View("LessonPlanningNew");
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





        [HttpGet]
        public IActionResult ViewExamData()
        {
            var exam = _context.tblExamTerm.ToList(); // Fetch all academic years
            return View("ExamTermEdit", exam); // Pass the list to the view
        }
        [HttpGet]
        public IActionResult ViewTimeTable()
        {
            var timeTableData = _context.tblTimeTableHD.ToList(); // Fetch the data
            return View("Timetable", timeTableData); // Path to the view file
        }

    }
}
