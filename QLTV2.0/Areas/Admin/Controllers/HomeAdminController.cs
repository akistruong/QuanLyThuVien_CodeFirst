using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace QLTV2._0.Areas.Admin.Controllers
{
    
    [Area("Admin")]
    [Authorize(Roles ="1")]
    public class HomeAdminController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
