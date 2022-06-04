using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QLTV2._0.Models;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

namespace QLTV2._0.Areas.Admin.Controllers
{
    
    [Area("Admin")]
    [Authorize(Roles ="1")]
    public class HomeAdminController : Controller
    {
        readonly QuanLyThuVien30Context _context;

        public HomeAdminController(QuanLyThuVien30Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> DoanhSo()
        {
            Dictionary<string,decimal> dict = new Dictionary<string, decimal>();
            List<decimal> total = new List<decimal>();
            for (int i = 1; i <= 12; i++)
            {
                decimal response = (decimal)_context.Hoadons.Where(x => x.Createdat.Value.Month == i).Sum(x => x.TongHoaDon);
                total.Add(response);
                dict.Add("T"+i,response);
            }
            return Json(new {
                total,
                AvrTotal = total.Sum()/12,
                ordersSum = DonHangThangNay(),
                pendingOrder = DonHangChoXacNhan(),
            });

        }
        decimal DoanhSoThangNay()
        { 
            var month = DateTime.Now.Month;
            var res = (decimal)_context.Hoadons.Where(x=>x.Createdat.Value.Month==month).Sum(x=>x.TongHoaDon);
            return res;
        }
        int DonHangThangNay()
        {
            var month = DateTime.Now.Month;
            var res = (int)_context.Hoadons.Where(x => x.Createdat.Value.Month == month).Where(x=>x.Status==1).Count();
            return res;
        }
        int DonHangChoXacNhan()
        {
            var res = (int)_context.Hoadons.Where(x => x.Status == 0).Count();
            return res;
        }   
        //Sach SachBanChay()
        //{
        //    var res = (int)_context.Hoadons.Where(x => x.Status == 0).Count();
        //    return res;
        //}
    }
}
