using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QLTV2._0.Models;
using System.Threading.Tasks;

namespace QLTV2._0.Views.Components.CategoryComponent
{
    public class CategoryComponent:ViewComponent
    {
        private readonly QuanLyThuVien30Context _context;

        public CategoryComponent(QuanLyThuVien30Context context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories =await (_context.Theloais).ToListAsync();
            return View("Category", categories);
        }
    }
}
