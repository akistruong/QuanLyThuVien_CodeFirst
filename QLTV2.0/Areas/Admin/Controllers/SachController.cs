using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QLTV2._0.Helper;
using QLTV2._0.Models;

namespace QLTV2._0.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class SachController : Controller
    {
        private readonly QuanLyThuVien30Context _context;
        
        public SachController(QuanLyThuVien30Context context)
        {
            _context = context;
        }
        [Authorize]
        // GET: Admin/Sach
        public async Task<IActionResult> Index(int page,  string search)
        {

            page = page == 0 ? 1 : page;
            var sachs = await _context.Saches.Include(x=>x.MaphieunhapNavigation).Include(x=>x.ManxbNavigation).Include(x=>x.MatheloaiNavigation).ToListAsync();
            if(!String.IsNullOrEmpty(search))
            {
                sachs = sachs.FindAll(x => x.Tensach.ToLower().Contains(search.ToLower())||x.Masach.ToLower().Trim()==search.ToLower().Trim()).ToList();
            }
            return View(await PaggingService<Sach>.CreateAsync(sachs, page,5));
        }

        // GET: Admin/Sach/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sach = await _context.Saches
                .Include(s => s.ManxbNavigation)
                .Include(s => s.MaphieunhapNavigation)
                .Include(s => s.MatheloaiNavigation)
                .FirstOrDefaultAsync(m => m.Masach == id);
            if (sach == null)
            {
                return NotFound();
            }

            return View(sach);
        }

        // GET: Admin/Sach/Create
        public IActionResult Create()
        {
            ViewData["Manxb"] = new SelectList(_context.Nxbs, "Manxb", "Tennxb");
            ViewData["Maphieunhap"] = new SelectList(_context.Phieunhaps, "Maphieunhap", "Maphieunhap");
            ViewData["Matheloai"] = new SelectList(_context.Theloais, "Matheloai", "Tentheloai");
            return View();
        }

        // POST: Admin/Sach/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdSach,Masach,Manxb,Maphieunhap,Matheloai,Tensach,Giaban,Img,Createdat,UpdatedAt,Mota")] Sach sach)
        {
            if (ModelState.IsValid)
            {
                var Phieu = _context.Phieunhaps.Where(x=>x.Maphieunhap == sach.Maphieunhap).First();
                sach.Slton = Phieu.Soluongnhap;
                
                _context.Add(sach);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Manxb"] = new SelectList(_context.Nxbs, "Manxb", "Manxb", sach.Manxb);
            ViewData["Maphieunhap"] = new SelectList(_context.Phieunhaps, "Maphieunhap", "Maphieunhap", sach.Maphieunhap);
            ViewData["Matheloai"] = new SelectList(_context.Theloais, "Matheloai", "Matheloai", sach.Matheloai);
            return View(sach);
        }

        // GET: Admin/Sach/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sach = await _context.Saches.FindAsync(id);
            if (sach == null)
            {
                return NotFound();
            }
            ViewData["Manxb"] = new SelectList(_context.Nxbs, "Manxb", "Manxb", sach.Manxb);
            ViewData["Maphieunhap"] = new SelectList(_context.Phieunhaps, "Maphieunhap", "Maphieunhap", sach.Maphieunhap);
            ViewData["Matheloai"] = new SelectList(_context.Theloais, "Matheloai", "Matheloai", sach.Matheloai);
            return View(sach);
        }

        // POST: Admin/Sach/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Masach,Manxb,Maphieunhap,Matheloai,Tensach,Giaban,Img,Slton,Createdat,UpdatedAt,Mota")] Sach sach)
        {
            if (id != sach.Masach)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sach);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SachExists(sach.Masach))
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
            ViewData["Manxb"] = new SelectList(_context.Nxbs, "Manxb", "Manxb", sach.Manxb);
            ViewData["Maphieunhap"] = new SelectList(_context.Phieunhaps, "Maphieunhap", "Maphieunhap", sach.Maphieunhap);
            ViewData["Matheloai"] = new SelectList(_context.Theloais, "Matheloai", "Matheloai", sach.Matheloai);
            return View(sach);
        }

        // GET: Admin/Sach/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sach = await _context.Saches
                .Include(s => s.ManxbNavigation)
                .Include(s => s.MaphieunhapNavigation)
                .Include(s => s.MatheloaiNavigation)
                .FirstOrDefaultAsync(m => m.Masach == id);
            if (sach == null)
            {
                return NotFound();
            }

            return View(sach);
        }

        // POST: Admin/Sach/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var sach = await _context.Saches.FindAsync(id);
            _context.Saches.Remove(sach);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SachExists(string id)
        {
            return _context.Saches.Any(e => e.Masach == id);
        }
        //POST : Admin/Sach/Checkkey
        [HttpPost]
        public IActionResult CheckKey(String MaSach)
        {
            var sach = _context.Saches.FirstOrDefault(x => x.Masach == MaSach);
            if(sach is  null)
            {
                return Json(new
                {
                    success = true,

                });
            }
            else
            {
                return Json(new
                {
                    success = false,

                });
            }
            
        }
    }
}
