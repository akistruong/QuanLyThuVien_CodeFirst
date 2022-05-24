using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QLTV2._0.Models;
using System.Linq;

namespace QLTV2._0.Areas.Me.Controllers
{
    [Area("Me")]
    public class MyOrderController : Controller
    {
        readonly QuanLyThuVien30Context _context;

        public MyOrderController(QuanLyThuVien30Context context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("/me/my-orders")]
        public IActionResult Index(string? id)
        {
            var taikhoan = _context.Taikhoans.FirstOrDefault(x=>x.UserName==id);
            if(taikhoan != null)
            {
                var orders = (_context.Hoadons).Include(x=>x.Chitiethoadons).Where(x => x.IdKh == taikhoan.IdKh).Where(x=>x.Status==1).ToList();
                return View(orders);
            }

            return Ok();
        }
        [HttpPost]
        public IActionResult DetailOrder(int? id)
        {
            var chitiethoadons = _context.Chitiethoadons.Include(x=>x.IdHoadonNavigation).Include(x=>x.MasachNavigation).Where(x => x.IdHoadon==id);
            if (chitiethoadons != null)
            {
                return Json(chitiethoadons);
            }

            return NotFound();  
        }
    }
}
