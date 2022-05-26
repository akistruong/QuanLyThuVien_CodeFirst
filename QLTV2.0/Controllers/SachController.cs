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
        public IActionResult Index(int id)
        {
            
            var res = _context.Saches.Include(x=>x.Chitiettacgia).ThenInclude(x=>x.IdTacgiaNavigation).Include(x=>x.ManxbNavigation).FirstOrDefault(x=>x.IdSach==id);
            var mayLike = _context.Saches.Where(x => x.Matheloai == res.Matheloai).ToList();
            ViewData["mayLike"] = mayLike;
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
 