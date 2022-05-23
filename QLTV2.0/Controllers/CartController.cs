using Microsoft.AspNetCore.Mvc;
using QLTV2._0.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.IO;
using QLTV2._0.Models.CartComponentModels;

namespace QLTV2._0.Controllers
{
    public class CartController : Controller
    {
        private readonly QuanLyThuVien30Context _context;

        public CartController(QuanLyThuVien30Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var items = HttpContext.Session.Get("Cart");
            if(items != null)
            {
                var data = JsonSerializer.Deserialize<List<CartItems>>(items);
                var totalBill = data.Sum(x => x.total);
                return View(data.ToList());
            }
            
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddToCart(int id)
        {
            var items = HttpContext.Session.Get("Cart");
            
            if (items != null)
            {
                var sach = await _context.Saches.FirstOrDefaultAsync(x=>x.IdSach==id);
                Stream stream = new MemoryStream(items);
                if (sach is not null)
                {
                    
                    var data = await JsonSerializer.DeserializeAsync<List<CartItems>>(stream);
                    var item = data.FirstOrDefault(x => x.items.IdSach == sach.IdSach);
                    if (item is not null)
                    {
                        item.qty++;
                        item.total= (decimal)(item.qty * item.items.Giaban);
                        var cart = JsonSerializer.Serialize(data);
                        HttpContext.Session.SetString("Cart", cart);
                        return Json(new
                        {
                            success = true,
                            items = data
                        }) ;
                    }
                    else
                    {
                        data.Add(new CartItems(sach, 1));
                        var cart = JsonSerializer.Serialize(data);
                        HttpContext.Session.SetString("Cart", cart);
                        return Json(new
                        {
                            success = true,
                            items = data
                        });
                        return BadRequest();
                    }
                   
                }
                else
                {
                    return BadRequest();
                }
            }
            else
            {
                var sach = await _context.Saches.FirstOrDefaultAsync(x => x.IdSach == id);
                if(sach is not null)
                {
                    var cartitems = new List<CartItems>();
                    cartitems.Add(new CartItems(sach, 1));
                    var item = JsonSerializer.Serialize(cartitems);
                    HttpContext.Session.SetString("Cart", item);

                    return Json(new
                    {
                        success = true,
                        items = cartitems
                    });
                }
               return BadRequest();
            }
            
        }
        [HttpPost]
        public async Task<IActionResult> UpdateQty(int id,int qty)
        {
            var items = HttpContext.Session.Get("Cart");
            Stream stream = new MemoryStream(items);
            var data = await JsonSerializer.DeserializeAsync<List<CartItems>>(stream);
            var res = data.FirstOrDefault(x => x.items.IdSach == id);
            if(res !=null)
            {
                res.qty = qty;
                res.total =(decimal) res.items.Giaban * qty;
                var cart = JsonSerializer.Serialize(data);
                HttpContext.Session.SetString("Cart", cart);
                return Json(new
                {
                    success = true,
                    qty= data.Sum(x=>x.qty),
                    item = res,
                    finalPrice = data.Sum(x => x.total)
                }) ;
            }
            else
            {
                return Json(new
                {
                    success = false,
                });
            }
            
        }
        [HttpPost]
        public async Task<IActionResult> DeleteCart(int id)
        {
            var items = HttpContext.Session.Get("Cart");
            Stream stream = new MemoryStream(items);
            var data = await JsonSerializer.DeserializeAsync<List<CartItems>>(stream);
            var res = data.FirstOrDefault(x => x.items.IdSach == id);
            if (res != null)
            {
                data.Remove(res);
                var cart = JsonSerializer.Serialize(data);
                HttpContext.Session.SetString("Cart", cart);
                return Json(new
                {
                    success = true,
                    qtyDelete = res.qty,
                    item = res,
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
        [HttpGet]
        public async Task<IActionResult> CheckQtyCart()
        {
            var items = HttpContext.Session.Get("Cart");
          
            if (items != null)
            {
                Stream stream = new MemoryStream(items);
                var data = await JsonSerializer.DeserializeAsync<List<CartItems>>(stream);
                var cart = JsonSerializer.Serialize(data);
                HttpContext.Session.SetString("Cart", cart);
                return Json(new
                {
                    success = true,
                    qty = data.Sum(x=>x.qty),
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
