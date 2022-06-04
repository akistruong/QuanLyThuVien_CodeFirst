using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QLTV2._0.Helper;
using QLTV2._0.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace QLTV2._0.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "1")]
    public class DonHangController : Controller
    {
        readonly QuanLyThuVien30Context _context;

        public DonHangController(QuanLyThuVien30Context context)
        {
            _context = context;
        }

        [Route("Admin/don-hang")]
        public async Task<IActionResult> Index(int? status)
        {
            var orders = await _context.Hoadons.Include(x=>x.IdKhNavigation).Where(x=>x.Status==0).ToListAsync();
            if (status is not null)
            {
                if(status == 1)
                {
                    orders = await _context.Hoadons.Include(x => x.IdKhNavigation).Where(x=>x.Status==1).ToListAsync();
                }
                else
                {
                    orders = await _context.Hoadons.Include(x=>x.IdKhNavigation).Where(x => x.Status == 0).ToListAsync();
                }
            }
            return View(orders);
        }
        [HttpPost]
        public async Task<IActionResult> ConfirmDeleteOrder(int orderId)
        {
            var items = await _context.Chitiethoadons.Where(x => x.IdHoadon == orderId).ToListAsync();
            foreach(var item in items)
            {
                var sach = _context.Saches.FirstOrDefault(x => x.Masach == item.Masach);
                if (sach != null)
                {
                    sach.Slton += item.Slmua;
                   
                }
                _context.Chitiethoadons.Remove(item);
            }
           var res = await _context.SaveChangesAsync();
            if(res>0)
            {
                var hoadon = await _context.Hoadons.FirstOrDefaultAsync(x=>x.IdHoadon == orderId);
                if(hoadon!=null)
                {
                    _context.Hoadons.Remove(hoadon);
                    await _context.SaveChangesAsync();
                    return Ok(new
                    {
                        success=true,
                    });
                }
                
            }
            return Ok();
        }
        public async Task<IActionResult> ConfirmOrder(int orderId)
        {
             var hoadon = await _context.Hoadons.Include(x=>x.IdKhNavigation).FirstOrDefaultAsync(x => x.IdHoadon == orderId);
            var chitiethoadon = await _context.Chitiethoadons.Include(x => x.MasachNavigation).Where(x=>x.IdHoadon==hoadon.IdHoadon).ToListAsync();
                if (hoadon != null)
                {
                
                try
                {
                    hoadon.Status = 1;
                    await _context.SaveChangesAsync();
                    var sendMailService = HttpContext.RequestServices.GetService<SendMailService>();
                    var mailContent = new MailBody();
                    mailContent.To = hoadon.IdKhNavigation.Email;
                    mailContent.Subject = "Eshopper - XÁC NHẬN ĐẶT HÀNG THÀNH CÔNG";
                    var detailOrders = EmailTemplate.DetailsOrder(chitiethoadon);
                    mailContent.Body =EmailTemplate.Html(hoadon,detailOrders);  
                    var res=  sendMailService.SendMail(mailContent);
                        return Ok(new
                        {
                            success = true,
                        });

                }
                catch (Exception e)
                {
                   return BadRequest(e.Message);
                }
                }

            
            return Ok();
        }
    }
}
