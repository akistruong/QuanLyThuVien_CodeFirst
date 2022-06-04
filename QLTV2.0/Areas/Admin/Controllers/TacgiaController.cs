using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QLTV2._0.Models;

namespace QLTV2._0.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "1")]
    public class TacgiaController : Controller
    {
        private readonly QuanLyThuVien30Context _context;

        public TacgiaController(QuanLyThuVien30Context context)
        {
            _context = context;
        }

        // GET: Admin/Tacgia
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tacgia.ToListAsync());
        }

        // GET: Admin/Tacgia/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tacgia = await _context.Tacgia
                .FirstOrDefaultAsync(m => m.IdTacgia == id);
            if (tacgia == null)
            {
                return NotFound();
            }

            return View(tacgia);
        }

        // GET: Admin/Tacgia/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Tacgia/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTacgia,Tentacgia")] Tacgia tacgia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tacgia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tacgia);
        }

        // GET: Admin/Tacgia/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tacgia = await _context.Tacgia.FindAsync(id);
            if (tacgia == null)
            {
                return NotFound();
            }
            return View(tacgia);
        }

        // POST: Admin/Tacgia/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdTacgia,Tentacgia")] Tacgia tacgia)
        {
            if (id != tacgia.IdTacgia)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tacgia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TacgiaExists(tacgia.IdTacgia))
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
            return View(tacgia);
        }

        // GET: Admin/Tacgia/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tacgia = await _context.Tacgia
                .FirstOrDefaultAsync(m => m.IdTacgia == id);
            if (tacgia == null)
            {
                return NotFound();
            }

            return View(tacgia);
        }

        // POST: Admin/Tacgia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tacgia = await _context.Tacgia.FindAsync(id);
            _context.Tacgia.Remove(tacgia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TacgiaExists(int id)
        {
            return _context.Tacgia.Any(e => e.IdTacgia == id);
        }
    }
}
