using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcProject.Data;
using MvcProject.Models;
using NetMVC.Models.Process;

namespace MvcProject.Controllers
{
    public class HeThongPPController : Controller
    {
        private readonly ApplicationDbContext _context;
        private ExcelProcess _excelProcess = new ExcelProcess();
        public HeThongPPController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: HeThongPP
        public async Task<IActionResult> Index()
        {
            return _context.HeThongPP != null ?
                        View(await _context.HeThongPP.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.HeThongPP'  is null.");
        }

        // GET: HeThongPP/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.HeThongPP == null)
            {
                return NotFound();
            }

            var heThongPP = await _context.HeThongPP
                .FirstOrDefaultAsync(m => m.MaHTPP == id);
            if (heThongPP == null)
            {
                return NotFound();
            }

            return View(heThongPP);
        }

        // GET: HeThongPP/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HeThongPP/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaHTPP,TenHTPP")] HeThongPP heThongPP)
        {
            if (ModelState.IsValid)
            {
                _context.Add(heThongPP);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(heThongPP);
        }

        // GET: HeThongPP/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.HeThongPP == null)
            {
                return NotFound();
            }

            var heThongPP = await _context.HeThongPP.FindAsync(id);
            if (heThongPP == null)
            {
                return NotFound();
            }
            return View(heThongPP);
        }

        // POST: HeThongPP/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaHTPP,TenHTPP")] HeThongPP heThongPP)
        {
            if (id != heThongPP.MaHTPP)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(heThongPP);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HeThongPPExists(heThongPP.MaHTPP))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(heThongPP);
        }

        // GET: HeThongPP/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.HeThongPP == null)
            {
                return NotFound();
            }

            var heThongPP = await _context.HeThongPP
                .FirstOrDefaultAsync(m => m.MaHTPP == id);
            if (heThongPP == null)
            {
                return NotFound();
            }

            return View(heThongPP);
        }


        // POST: HeThongPP/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.HeThongPP == null)
            {
                return Problem("Entity set 'ApplicationDbContext.HeThongPP'  is null.");
            }
            var heThongPP = await _context.HeThongPP.FindAsync(id);
            if (heThongPP != null)
            {
                _context.HeThongPP.Remove(heThongPP);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HeThongPPExists(int id)
        {
            return (_context.HeThongPP?.Any(e => e.MaHTPP == id)).GetValueOrDefault();
        }


        //upload
        public async Task<IActionResult> Upload()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            if (file != null)
            {
                string fileExtension = Path.GetExtension(file.FileName);
                if (fileExtension != ".xls" && fileExtension != ".xlsx")
                {
                    ModelState.AddModelError("", "Please choose excel file to upload!");
                }
                else
                {
                    //renanme file when upload to sever
                    var fileName = DateTime.Now.ToShortTimeString() + fileExtension;
                    var filePath = Path.Combine(Directory.GetCurrentDirectory() + "/Uploads/Excels", fileName);
                    var fileLocation = new FileInfo(filePath).ToString();
                    var directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "Uploads", "Excels");
                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        //save file to server 
                        await file.CopyToAsync(stream);
                        var dt = _excelProcess.ExcelToDataTable(fileLocation);
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            var ht = new HeThongPP();
                            ht.TenHTPP = dt.Rows[i][1].ToString();
                            _context.Add(ht);
                        }
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }

                }
            }
            return View();
        }
    }
}
