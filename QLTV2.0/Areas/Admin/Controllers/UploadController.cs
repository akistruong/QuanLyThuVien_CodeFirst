using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLTV2._0.Models;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace QLTV2._0.Areas.Admin.Controllers
{
    public class UploadController : Controller
    {
        private readonly QuanLyThuVien30Context _context;
        public UploadController(QuanLyThuVien30Context context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("/Upload/{ma}")]
        public async Task<IActionResult> Upload(string? ma)
        {
            var file = Request.Form.Files[0];
            if (file == null || file.Length == 0)
            {
                return View("Error");
            }
            else
            {
                var path = Path.Combine(
                  Directory.GetCurrentDirectory(), "wwwroot//assets//ImgThumb//",
                  file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                   try
                    { 
                        await file.CopyToAsync(stream);
                       var sach= _context.Saches.FirstOrDefault(x => x.Masach == ma);
                        if (sach != null)
                        {
                            sach.Img = file.FileName;
                            var res = await _context.SaveChangesAsync();
                            if(res >0)
                            {
                                return Json(new
                                {
                                    success = true

                                });
                            }
                            else
                            {
                                return Json(new
                                {
                                    success = false

                                });
                            }
                        }
                     
                    }
                    catch(Exception err)
                    {
                        return Json(new
                        {
                            success = false
                        });
                    }
                  
                }
            }
           return View("Error");
        }
     
    }
}
