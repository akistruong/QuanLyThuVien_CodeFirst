using Microsoft.AspNetCore.Mvc;
using QLTV2._0.Models;
using System.Linq;

namespace QLTV2._0.Areas.Me.Controllers
{
    [Area("Me")]
    public class MeController : Controller
    {
        readonly QuanLyThuVien30Context _context;
        public IActionResult Index(string? id)
        {
            
            return View();
        }
    }
}
