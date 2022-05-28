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
    public class TheloaiController : Controller
    {
        private readonly QuanLyThuVien30Context _context;

        public TheloaiController(QuanLyThuVien30Context context)
        {
            _context = context;
        }

        // GET: Admin/Theloai
        public async Task<IActionResult> Index()
        {
            return View(await _context.Theloais.ToListAsync());
        }

        // GET: Admin/Theloai/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var theloai = await _context.Theloais
                .FirstOrDefaultAsync(m => m.Matheloai == id);
            if (theloai == null)
            {
                return NotFound();
            }

            return View(theloai);
        }

        // GET: Admin/Theloai/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Theloai/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTheloai,Matheloai,Tentheloai")] Theloai theloai)
        {
            if (ModelState.IsValid)
            {
                var tl = _context.Theloais.FirstOrDefault(x => x.Matheloai == theloai.Matheloai);
                if(tl is  null)
                {
                    _context.Add(theloai);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();
                }
               
            }
            return View(theloai);
        }

        // GET: Admin/Theloai/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var theloai = await _context.Theloais.FindAsync(id);
            if (theloai == null)
            {
                return NotFound();
            }
            return View(theloai);
        }

        // POST: Admin/Theloai/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IdTheloai,Matheloai,Tentheloai")] Theloai theloai)
        {
            if (id != theloai.Matheloai)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(theloai);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TheloaiExists(theloai.Matheloai))
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
            return View(theloai);
        }

        // GET: Admin/Theloai/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var theloai = await _context.Theloais
                .FirstOrDefaultAsync(m => m.Matheloai == id);
            if (theloai == null)
            {
                return NotFound();
            }

            return View(theloai);
        }

        // POST: Admin/Theloai/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var theloai = await _context.Theloais.FindAsync(id);
            _context.Theloais.Remove(theloai);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TheloaiExists(string id)
        {
            return _context.Theloais.Any(e => e.Matheloai == id);
        }
    }
}
