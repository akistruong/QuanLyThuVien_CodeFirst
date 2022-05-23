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
    public class ChiTietTacGiaController : Controller
    {
        private readonly QuanLyThuVien30Context _context;

        public ChiTietTacGiaController(QuanLyThuVien30Context context)
        {
            _context = context;
        }

        // GET: Admin/ChiTietTacGia
        public async Task<IActionResult> Index()
        {
            var quanLyThuVien30Context = await _context.Chitiettacgia.Include(c => c.IdTacgiaNavigation).Include(c => c.MasachNavigation).ToListAsync();
            var data = quanLyThuVien30Context.GroupBy(g=>g.IdTacgia).Select(x=>x.First()).ToList();
            return View(data);
        }

        // GET: Admin/ChiTietTacGia/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chitiettacgia = await _context.Chitiettacgia
                .Include(c => c.IdTacgiaNavigation)
                .Include(c => c.MasachNavigation)
                .Where(m => m.IdTacgia == id).ToListAsync();
            if (chitiettacgia == null)
            {
                return NotFound();
            }

            return View(chitiettacgia);
        }

        // GET: Admin/ChiTietTacGia/Create
        public IActionResult Create()
        {
            ViewData["IdTacgia"] = new SelectList(_context.Tacgia, "IdTacgia", "Tentacgia");
            ViewData["Masach"] = new SelectList(_context.Saches, "Masach", "Tensach");
            return View();
        }

        // POST: Admin/ChiTietTacGia/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Masach,IdTacgia")] Chitiettacgia chitiettacgia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chitiettacgia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdTacgia"] = new SelectList(_context.Tacgia, "IdTacgia", "IdTacgia", chitiettacgia.IdTacgia);
            ViewData["Masach"] = new SelectList(_context.Saches, "Masach", "Masach", chitiettacgia.Masach);
            return View(chitiettacgia);
        }

        // GET: Admin/ChiTietTacGia/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chitiettacgia = await _context.Chitiettacgia.FindAsync(id);
            if (chitiettacgia == null)
            {
                return NotFound();
            }
            ViewData["IdTacgia"] = new SelectList(_context.Tacgia, "IdTacgia", "IdTacgia", chitiettacgia.IdTacgia);
            ViewData["Masach"] = new SelectList(_context.Saches, "Masach", "Masach", chitiettacgia.Masach);
            return View(chitiettacgia);
        }

        // POST: Admin/ChiTietTacGia/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Masach,IdTacgia")] Chitiettacgia chitiettacgia)
        {
            if (id != chitiettacgia.Masach)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chitiettacgia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChitiettacgiaExists(chitiettacgia.Masach))
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
            ViewData["IdTacgia"] = new SelectList(_context.Tacgia, "IdTacgia", "IdTacgia", chitiettacgia.IdTacgia);
            ViewData["Masach"] = new SelectList(_context.Saches, "Masach", "Masach", chitiettacgia.Masach);
            return View(chitiettacgia);
        }

        // GET: Admin/ChiTietTacGia/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chitiettacgia = await _context.Chitiettacgia
                .Include(c => c.IdTacgiaNavigation)
                .Include(c => c.MasachNavigation)
                .FirstOrDefaultAsync(m => m.Masach == id);
            if (chitiettacgia == null)
            {
                return NotFound();
            }

            return View(chitiettacgia);
        }

        // POST: Admin/ChiTietTacGia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var chitiettacgia = await _context.Chitiettacgia.FindAsync(id);
            _context.Chitiettacgia.Remove(chitiettacgia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChitiettacgiaExists(string id)
        {
            return _context.Chitiettacgia.Any(e => e.Masach == id);
        }
    }
}
