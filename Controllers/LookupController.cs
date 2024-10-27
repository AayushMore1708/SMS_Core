using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SMS_Core.Models;
using SMS_Core.ViewModel;
using System.Linq;
using System.Threading.Tasks;

namespace SMS_Core.Controllers
{
    public class LookupController : Controller
    {
         private readonly SMSDbContext _context;

        // Inject DbContext through constructor
        public LookupController(SMSDbContext db)
        {
            _context = db;
        }

        // Department Actions
        public IActionResult DepartmentNew()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DepartmentNew(lkpDepartment dp)
        {
            if (ModelState.IsValid)
            {
                _context.lkpDepartment.Add(dp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(DepartmentNew));
            }
            return View(dp);
        }

        public async Task<IActionResult> DepartmentEdit(int id)
        {
            var dp = await _context.lkpDepartment.FindAsync(id);
            if (dp == null) return NotFound();
            return View(dp);
        }

        [HttpPost]
        public async Task<IActionResult> DepartmentEdit(lkpDepartment dp)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(dp).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(DepartmentNew));
            }
            return View(dp);
        }

        public async Task<IActionResult> DepartmentView()
        {
            var departments = await _context.lkpDepartment
                .OrderBy(x => x.Department)
                .ToListAsync();
            return PartialView(departments);
        }

        // Designation Actions
        public IActionResult DesignationNew()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DesignationNew(lkpDesignation ds)
        {
            if (ModelState.IsValid)
            {
                _context.lkpDesignation.Add(ds);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(DesignationNew));
            }
            return View(ds);
        }

        public async Task<IActionResult> DesignationEdit(int id)
        {
            var ds = await _context.lkpDesignation.FindAsync(id);
            if (ds == null) return NotFound();
            return View(ds);
        }

        [HttpPost]
        public async Task<IActionResult> DesignationEdit(lkpDesignation ds)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(ds).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(DesignationNew));
            }
            return View(ds);
        }

        public async Task<IActionResult> DesignationView()
        {
            var designations = await _context.lkpDesignation
                .OrderBy(x => x.Designation)
                .ToListAsync();
            return PartialView(designations);
        }

        // Category Actions
        public IActionResult CategoryNew()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CategoryNew(lkpCategory cg)
        {
            if (ModelState.IsValid)
            {
                _context.lkpCategory.Add(cg);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(CategoryNew));
            }
            return View(cg);
        }

        public async Task<IActionResult> CategoryEdit(int id)
        {
            var cg = await _context.lkpCategory.FindAsync(id);
            if (cg == null) return NotFound();
            return View(cg);
        }

        [HttpPost]
        public async Task<IActionResult> CategoryEdit(lkpCategory cg)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(cg).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(CategoryNew));
            }
            return View(cg);
        }

        public async Task<IActionResult> CategoryView()
        {
            var categories = await _context.lkpCategory
                .OrderBy(x => x.Category)
                .ToListAsync();
            return PartialView(categories);
        }

        // Religion Actions
        public IActionResult ReligionNew()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ReligionNew(lkpReligion rg)
        {
            if (ModelState.IsValid)
            {
                _context.lkpReligion.Add(rg);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ReligionNew));
            }
            return View(rg);
        }

        public async Task<IActionResult> ReligionEdit(int id)
        {
            var rg = await _context.lkpReligion.FindAsync(id);
            if (rg == null) return NotFound();
            return View(rg);
        }

        [HttpPost]
        public async Task<IActionResult> ReligionEdit(lkpReligion rg)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(rg).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ReligionNew));
            }
            return View(rg);
        }

        public async Task<IActionResult> ReligionView()
        {
            var religions = await _context.lkpReligion
                .OrderBy(x => x.Religion)
                .ToListAsync();
            return PartialView(religions);
        }

        // Caste Actions
        public IActionResult CasteNew()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CasteNew(lkpCaste ct)
        {
            if (ModelState.IsValid)
            {
                _context.lkpCaste.Add(ct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(CasteNew));
            }
            return View(ct);
        }

        public async Task<IActionResult> CasteEdit(int id)
        {
            var ct = await _context.lkpCaste.FindAsync(id);
            if (ct == null) return NotFound();
            return View(ct);
        }

        [HttpPost]
        public async Task<IActionResult> CasteEdit(lkpCaste ct)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(ct).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(CasteNew));
            }
            return View(ct);
        }

        public async Task<IActionResult> CasteView()
        {
            var castes = await _context.lkpCaste
                .OrderBy(x => x.Caste)
                .ToListAsync();
            return PartialView(castes);
        }
    }
}
