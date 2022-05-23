using Microsoft.AspNetCore.Mvc;
using QLTV2._0.Models;
using System.Linq;

namespace QLTV2._0.Areas.Me.Controllers
{
    [Area("Me")]
    public class SettingsController : Controller
    {
        readonly QuanLyThuVien30Context _context;

        public SettingsController(QuanLyThuVien30Context context)
        {
            _context = context;
        }

        public IActionResult Index(string? id)
        {
            var googleacc = _context.Taikhoans.FirstOrDefault(x => x.UserName == id);
            if(googleacc == null)
            {
                return View();
            }
            else
            {
                var kh = _context.KhachHangs.FirstOrDefault(x => x.IdKh == googleacc.IdKh);
                return View(kh);
            }


        }
        [HttpPost]
        [Route("/me/thiet-lap")]
        public IActionResult UpateProfile(int? id,KhachHang body)
        {
            var kh = _context.KhachHangs.FirstOrDefault(x=>x.IdKh==id); 
            if(kh == null)
            {
                return View();
            }
            else
            {
                kh.DiaChi = body.DiaChi;
                kh.Sdt = body.Sdt;
                kh.TenKhachHang = body.TenKhachHang;
                kh.Ngaysinh= body.Ngaysinh;
                kh.Gioitinh = body.Gioitinh;
                _context.KhachHangs.Update(kh);
                var res = _context.SaveChanges();
                if (res>0)
                {
                    return Json(new
                    {
                        success = true
                    }) ;
                }
                else
                {
                    return BadRequest();
                }
            }
        }
    }
}
