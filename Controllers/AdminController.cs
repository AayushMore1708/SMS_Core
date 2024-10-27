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
            var lp = _context.tblAssignmentNote.ToList();
            return View(lp);
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
                _context.tblAssignmentNote.Add(asbu);
                await _context.SaveChangesAsync();
                return RedirectToAction("../Admin/Assignement");
            }

            ViewBag.crc = _context.tblAcadamicCource;
            ViewBag.bat = _context.tblCourseBatch;
            ViewBag.sbu = _context.tblSubject;

            return View(asbu);
        }



        public ActionResult NotesEdit(int id)
        {
            ViewBag.crc = _context.tblAcadamicCource;
            ViewBag.bat = _context.tblCourseBatch;
            ViewBag.sbu = _context.tblSubject;

            var ae = _context.tblAssignmentNote.Find(id);

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

    }
}
