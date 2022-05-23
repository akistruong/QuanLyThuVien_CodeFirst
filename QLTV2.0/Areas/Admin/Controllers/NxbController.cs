using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QLTV2._0.Models;

namespace QLTV2._0.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NxbController : Controller
    {
        private readonly QuanLyThuVien30Context _context;

        public NxbController(QuanLyThuVien30Context context)
        {
            _context = context;
        }

        // GET: Admin/Nxb
        public async Task<IActionResult> Index()
        {
            return View(await _context.Nxbs.ToListAsync());
        }

        // GET: Admin/Nxb/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nxb = await _context.Nxbs
                .FirstOrDefaultAsync(m => m.Manxb == id);
            if (nxb == null)
            {
                return NotFound();
            }

            return View(nxb);
        }

        // GET: Admin/Nxb/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Nxb/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdNxb,Tennxb,Diachi,Sdt,Manxb")] Nxb nxb)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nxb);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nxb);
        }

        // GET: Admin/Nxb/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nxb = await _context.Nxbs.FindAsync(id);
            if (nxb == null)
            {
                return NotFound();
            }
            return View(nxb);
        }

        // POST: Admin/Nxb/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Tennxb,IdNxb,Diachi,Sdt,Manxb")] Nxb nxb)
        {
            if (id != nxb.Manxb)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nxb);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NxbExists(nxb.Manxb))
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
            return View(nxb);
        }

        // GET: Admin/Nxb/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nxb = await _context.Nxbs
                .FirstOrDefaultAsync(m => m.Manxb == id);
            if (nxb == null)
            {
                return NotFound();
            }

            return View(nxb);
        }

        // POST: Admin/Nxb/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var nxb = await _context.Nxbs.FindAsync(id);
            _context.Nxbs.Remove(nxb);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NxbExists(string id)
        {
            return _context.Nxbs.Any(e => e.Manxb == id);
        }
    }
}
