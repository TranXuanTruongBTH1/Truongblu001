using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using truongblu001.Models;

namespace truongblu001.Controllers
{
    public class TXTStudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TXTStudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TXTStudent
        public async Task<IActionResult> Index()
        {
              return _context.TXTStudent != null ? 
                          View(await _context.TXTStudent.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.TXTStudent'  is null.");
        }

        // GET: TXTStudent/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.TXTStudent == null)
            {
                return NotFound();
            }

            var tXTStudent = await _context.TXTStudent
                .FirstOrDefaultAsync(m => m.TXTID == id);
            if (tXTStudent == null)
            {
                return NotFound();
            }

            return View(tXTStudent);
        }

        // GET: TXTStudent/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TXTStudent/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TXTID,TXTSEX,TXTNAME")] TXTStudent tXTStudent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tXTStudent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tXTStudent);
        }

        // GET: TXTStudent/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.TXTStudent == null)
            {
                return NotFound();
            }

            var tXTStudent = await _context.TXTStudent.FindAsync(id);
            if (tXTStudent == null)
            {
                return NotFound();
            }
            return View(tXTStudent);
        }

        // POST: TXTStudent/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("TXTID,TXTSEX,TXTNAME")] TXTStudent tXTStudent)
        {
            if (id != tXTStudent.TXTID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tXTStudent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TXTStudentExists(tXTStudent.TXTID))
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
            return View(tXTStudent);
        }

        // GET: TXTStudent/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.TXTStudent == null)
            {
                return NotFound();
            }

            var tXTStudent = await _context.TXTStudent
                .FirstOrDefaultAsync(m => m.TXTID == id);
            if (tXTStudent == null)
            {
                return NotFound();
            }

            return View(tXTStudent);
        }

        // POST: TXTStudent/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.TXTStudent == null)
            {
                return Problem("Entity set 'ApplicationDbContext.TXTStudent'  is null.");
            }
            var tXTStudent = await _context.TXTStudent.FindAsync(id);
            if (tXTStudent != null)
            {
                _context.TXTStudent.Remove(tXTStudent);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TXTStudentExists(string id)
        {
          return (_context.TXTStudent?.Any(e => e.TXTID == id)).GetValueOrDefault();
        }
    }
}
