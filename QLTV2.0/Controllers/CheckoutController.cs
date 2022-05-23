using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QLTV2._0.Models;
using QLTV2._0.Models.CartComponentModels;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text.Json;

namespace QLTV2._0.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly QuanLyThuVien30Context _context;

        public CheckoutController(QuanLyThuVien30Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var items = HttpContext.Session.Get("Cart");

            if (items != null)
            {
                if(User.Identity.IsAuthenticated)
                {
                    var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                    var kh = _context.Taikhoans.Include(x=>x.IdKhNavigation).FirstOrDefault(x=>x.UserName == userId);
                    if(kh != null)
                    {
                        ViewData["KhachHang"] = kh;
                    }
                }
                var data = JsonSerializer.Deserialize<List<CartItems>>(items);
                var totalBill = data.Sum(x => x.total);
                return View(data.ToList());
            }
            else
            {
                return RedirectToAction("Index", "Cart");
            }

            return View();
        }
        [HttpPost("dat-hang")]
        public IActionResult CreateOrder(Hoadon hoadon,KhachHang kh)
        {
            var items = HttpContext.Session.Get("Cart");
            var data = JsonSerializer.Deserialize<List<CartItems>>(items);
            if (hoadon.IdKh is null)
            {
                var Khach = _context.KhachHangs.Add(kh);
                var ResKhach = _context.SaveChanges();
                if (ResKhach > 0)
                {
                   
                   
                    hoadon.Soluong = data.Sum(x => x.qty);
                    hoadon.TongHoaDon = data.Sum(x => x.total);
                    hoadon.IdKh = kh.IdKh;
                    var HoaDon = _context.Hoadons.Add(hoadon);
                    var HoaDonSave = _context.SaveChanges();
                    if (HoaDonSave > 0 && items != null)
                    {

                        foreach (var item in data)
                        {
                            Chitiethoadon chitiethoadon = new Chitiethoadon();
                            chitiethoadon.IdHoadon = hoadon.IdHoadon;
                            chitiethoadon.Masach = item.items.Masach;
                            chitiethoadon.Slmua = item.qty;
                            chitiethoadon.Thanhtien = item.total;
                            chitiethoadon.Dongia = item.items.Giaban;
                            _context.Chitiethoadons.Add(chitiethoadon);
                        }
                        var cthdSave = _context.SaveChanges();
                        if (cthdSave > 0)
                        {
                            HttpContext.Session.Clear();
                            return Json(new
                            {
                                success = true,
                                msg = "Đơn hàng đã được đặt, vui lòng chờ nhân viên xác nhận đơn hàng"
                            });
                        }
                        else
                        {
                            return BadRequest();
                        }
                    }
                }
            }
            else
            {
                hoadon.Soluong = data.Sum(x => x.qty);
                hoadon.TongHoaDon = data.Sum(x => x.total);
                hoadon.IdKh = kh.IdKh;
                var HoaDon = _context.Hoadons.Add(hoadon);
                var HoaDonSave = _context.SaveChanges();
                if (HoaDonSave > 0 && items != null)
                {

                    foreach (var item in data)
                    {
                        Chitiethoadon chitiethoadon = new Chitiethoadon();
                        chitiethoadon.IdHoadon = hoadon.IdHoadon;
                        chitiethoadon.Masach = item.items.Masach;
                        chitiethoadon.Slmua = item.qty;
                        chitiethoadon.Thanhtien = item.total;
                        chitiethoadon.Dongia = item.items.Giaban;
                        _context.Chitiethoadons.Add(chitiethoadon);
                    }
                    var cthdSave = _context.SaveChanges();
                    if (cthdSave > 0)
                    {
                        HttpContext.Session.Clear();
                        return Json(new
                        {
                            success = true,
                            msg = "Đơn hàng đã được đặt, vui lòng chờ nhân viên xác nhận đơn hàng"
                        });
                    }
                    else
                    {
                        return BadRequest();
                    }
                }
            }
            
           
            return BadRequest();

        }
        private IActionResult SuccessPage()
        {
            return View("SuccessPage");

        }
    }

   


}
