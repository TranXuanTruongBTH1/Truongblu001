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
    public class TXTCompanyController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TXTCompanyController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TXTCompany
        public async Task<IActionResult> Index()
        {
              return _context.TXTCompany != null ? 
                          View(await _context.TXTCompany.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.TXTCompany'  is null.");
        }

        // GET: TXTCompany/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.TXTCompany == null)
            {
                return NotFound();
            }

            var tXTCompany = await _context.TXTCompany
                .FirstOrDefaultAsync(m => m.CompanyID == id);
            if (tXTCompany == null)
            {
                return NotFound();
            }

            return View(tXTCompany);
        }

        // GET: TXTCompany/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TXTCompany/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyID,CompanyName,AddressID")] TXTCompany tXTCompany)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tXTCompany);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tXTCompany);
        }

        // GET: TXTCompany/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.TXTCompany == null)
            {
                return NotFound();
            }

            var tXTCompany = await _context.TXTCompany.FindAsync(id);
            if (tXTCompany == null)
            {
                return NotFound();
            }
            return View(tXTCompany);
        }

        // POST: TXTCompany/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CompanyID,CompanyName,AddressID")] TXTCompany tXTCompany)
        {
            if (id != tXTCompany.CompanyID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tXTCompany);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TXTCompanyExists(tXTCompany.CompanyID))
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
            return View(tXTCompany);
        }

        // GET: TXTCompany/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.TXTCompany == null)
            {
                return NotFound();
            }

            var tXTCompany = await _context.TXTCompany
                .FirstOrDefaultAsync(m => m.CompanyID == id);
            if (tXTCompany == null)
            {
                return NotFound();
            }

            return View(tXTCompany);
        }

        // POST: TXTCompany/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.TXTCompany == null)
            {
                return Problem("Entity set 'ApplicationDbContext.TXTCompany'  is null.");
            }
            var tXTCompany = await _context.TXTCompany.FindAsync(id);
            if (tXTCompany != null)
            {
                _context.TXTCompany.Remove(tXTCompany);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TXTCompanyExists(string id)
        {
          return (_context.TXTCompany?.Any(e => e.CompanyID == id)).GetValueOrDefault();
        }
    }
}
