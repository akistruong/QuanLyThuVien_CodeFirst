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
    public class PhieunhapController : Controller
    {
        private readonly QuanLyThuVien30Context _context;

        public PhieunhapController(QuanLyThuVien30Context context)
        {
            _context = context;
        }

        // GET: Admin/Phieunhap
        public async Task<IActionResult> Index()
        {
            return View(await _context.Phieunhaps.ToListAsync());
        }

        // GET: Admin/Phieunhap/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phieunhap = await _context.Phieunhaps
                .FirstOrDefaultAsync(m => m.Maphieunhap == id);
            if (phieunhap == null)
            {
                return NotFound();
            }

            return View(phieunhap);
        }

        // GET: Admin/Phieunhap/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Phieunhap/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPhieunhap,Maphieunhap,Soluongnhap,Gianhap,Createdat,UpdatedAt")] Phieunhap phieunhap)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phieunhap);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(phieunhap);
        }

        // GET: Admin/Phieunhap/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phieunhap = await _context.Phieunhaps.FindAsync(id);
            if (phieunhap == null)
            {
                return NotFound();
            }
            return View(phieunhap);
        }

        // POST: Admin/Phieunhap/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IdPhieunhap,Maphieunhap,Soluongnhap,Gianhap,Createdat,UpdatedAt")] Phieunhap phieunhap)
        {
            if (id != phieunhap.Maphieunhap)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phieunhap);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhieunhapExists(phieunhap.Maphieunhap))
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
            return View(phieunhap);
        }

        // GET: Admin/Phieunhap/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phieunhap = await _context.Phieunhaps
                .FirstOrDefaultAsync(m => m.Maphieunhap == id);
            if (phieunhap == null)
            {
                return NotFound();
            }

            return View(phieunhap);
        }

        // POST: Admin/Phieunhap/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var phieunhap = await _context.Phieunhaps.FindAsync(id);
            _context.Phieunhaps.Remove(phieunhap);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhieunhapExists(string id)
        {
            return _context.Phieunhaps.Any(e => e.Maphieunhap == id);
        }
    }
}
