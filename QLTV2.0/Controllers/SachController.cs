using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QLTV2._0.Models;
using System.Linq;

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
            ViewData["imgs"] = _context.Hinhanhs.Include(x=>x.MasachNavigation).Where(x=>x.MasachNavigation.IdSach==id).ToList();
            var res = _context.Saches.FirstOrDefault(x=>x.IdSach==id);
            if(res==null)
            {
                return NotFound();
            }
            else
            {
                return View(res);
            }
        }
    }
}
 