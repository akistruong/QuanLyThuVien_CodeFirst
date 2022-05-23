using Microsoft.AspNetCore.Mvc;

namespace QLTV2._0.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            switch(statusCode)
            {
                case 404:
                    return View("NotFound");
                    break;
                    
            }
            return View("NotFound");
            
        }
        [Route("Account/AccessDenied")]
        public IActionResult DeniedPage()
        {
            return LocalRedirect("/");
        }
    }
}
