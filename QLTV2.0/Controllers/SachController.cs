using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QLTV2._0.Models;
using System.Linq;
using System.Threading.Tasks;

namespace QLTV2._0.Controllers
{
    public class SachController : Controller
    {
        private readonly QuanLyThuVien30Context _context;

        public SachController(QuanLyThuVien30Context context)
        {
            _context = context;
        }

        [Route("/san-pham/{id}/{slug}")]
        public async Task<IActionResult> Index(int id)
        {
            
            var res = await _context.Saches.Include(x=>x.Chitiettacgia).ThenInclude(x=>x.IdTacgiaNavigation).Include(x=>x.ManxbNavigation).FirstOrDefaultAsync(x=>x.IdSach==id);
            var comments = await _context.Comments.Include(x => x.TaiKhoanNavigation).ThenInclude(x=>x.IdKhNavigation).Include(x => x.Replys).ThenInclude(x=>x.TaiKhoanNavigation).ThenInclude(x=>x.IdKhNavigation).Where(x=>x.Masach==res.Masach).ToListAsync();
            var mayLike = _context.Saches.Where(x => x.Matheloai == res.Matheloai).ToList();
            ViewData["mayLike"] = mayLike;
            ViewData["comments"] = comments;
            if(res==null)
            {
                return NotFound();
            }
            else
            {
                return View(res);
            }
        }
        [Route("/search")]
        public async Task< IActionResult> Search(string key)
        {
            var values = _context.Saches.Where(x => x.Tensach.Contains(key));
            if(values is not null )
            {
                return Json(values);
            }
           else
            {
                return Ok();
            }
        }
    }
}
 