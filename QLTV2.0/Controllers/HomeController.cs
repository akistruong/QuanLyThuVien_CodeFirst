using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using QLTV2._0.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace QLTV2._0.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly QuanLyThuVien30Context _context;

        public HomeController(ILogger<HomeController> logger, QuanLyThuVien30Context context)
        {
            _logger = logger;
            _context = context;

        }
        public IActionResult Index()
        {
            var productsNew = _context.Saches.OrderByDescending(x => x.Createdat).Where(x=>x.Slton>0).Take(5).ToList();
            var productsHot = _context.Chitiethoadons.Include(x => x.MasachNavigation).OrderByDescending(x=>x.Slmua).ToList().GroupBy(x => x.Masach).Select(x=>x.First()).Take(8).ToList();
            ViewData["productsNew"] = productsNew;
            ViewData["productsHot"] = productsHot;
                return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int? statusCode)
        {
            if (statusCode == 404)
            {
                return View("PageError/NotFound");
            }
            else
            {
                return View("PageError/NotFound");
            }
                
        }
    }
}
