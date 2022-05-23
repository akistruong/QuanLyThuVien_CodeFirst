using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLTV2._0.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace QLTV2._0.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HinhAnhController : Controller
    {
        IWebHostEnvironment _env;
        private readonly QuanLyThuVien30Context _context;
        public HinhAnhController(IWebHostEnvironment env, QuanLyThuVien30Context context)
        {
            _env = env;
            _context = context;
        }

        public IActionResult Index(string masach)
        {
            return View("HinhAnh");
        }
        [HttpPost("upload-anh-sach")]
        
        public async Task<IActionResult> UploadImgs(List<IFormFile> files,string? masach)
        {
            var root = _env.ContentRootPath + "//wwwroot//assets//HinhAnhSach//"+masach;
            bool c = Directory.Exists(root);
            if (!c)
            {
                var di = Directory.CreateDirectory(root);

            }
            foreach (IFormFile file in files)
            {
                var path = Path.Combine(root, file.FileName);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    try
                    {
                        await file.CopyToAsync(stream);
                        Hinhanh hinhanh = new Hinhanh();
                        hinhanh.Masach = masach;
                        hinhanh.Url = masach + "//" + file.FileName;
                        _context.Hinhanhs.Add(hinhanh);
                       var data = _context.SaveChanges();
                        var check = data;
                    }
                    catch (Exception err)
                    {

                    }

                }

            }


            return Ok();
        }
    }
}
