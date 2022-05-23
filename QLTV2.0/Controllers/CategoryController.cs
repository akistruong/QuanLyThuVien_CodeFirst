using Microsoft.AspNetCore.Mvc;
using QLTV2._0.Models;
using System;
using System.Linq;

namespace QLTV2._0.Controllers
{
    public class CategoryController : Controller
    {
        private readonly QuanLyThuVien30Context _context;

        public CategoryController(QuanLyThuVien30Context context)
        {
            _context = context;
        }

        [Route("danh-muc/{id}")]
        public IActionResult Index(string id)
        {
          
            return View();
        }
        [HttpGet]
        [Route("/api/GetBookByCategory")]
        public IActionResult GetBookByCategory(string id,string? price)
        {
            var sachs = _context.Saches.Where(x => x.Matheloai == id);
            if(sachs is not null)
            {
                if(!String.IsNullOrEmpty(price))
                {
                    var prices = price.Split(",");
                    if(prices.Length>1)
                    {
                        decimal priceEnd = Decimal.Parse(prices[1]);
                        decimal priceStart = Decimal.Parse(prices[0]);
                        sachs = sachs.Where(x => x.Giaban >= priceStart).Where(x => x.Giaban <= priceEnd);
                    }
                    else
                    {
                        sachs = _context.Saches.Where(x => x.Matheloai == id);
                       
                    }
                   
                }
                return Json(sachs);
            }
            else
            {
                return BadRequest();
            }
            
        }
    }
}
