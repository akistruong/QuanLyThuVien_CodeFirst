using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using QLTV2._0.Models;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Facebook;

namespace QLTV2._0.Controllers
{
    [Area("Admin")]
    public class AuthController : Controller
    {
        QuanLyThuVien30Context _context;
        public AuthController(QuanLyThuVien30Context context)
        {
            _context = context;
        }

        [Route("dang-nhap")]
        [HttpGet]
        public async Task<IActionResult> Login()
        {
            if(User.Identity.IsAuthenticated)
            {
                return LocalRedirect("/");
            }
            else
            {
                return View();
            }
            
        }
        [Route("dang-ky")]
        [HttpGet]
        public async Task<IActionResult> SignUp()
        {
            return View();
        }
        [Route("dang-nhap")]
        [HttpPost]
        public async Task<IActionResult> Login(Taikhoan body)
        {
            if(ModelState.IsValid)
            {
                var TaiKhoan = _context.Taikhoans.FirstOrDefault(x => x.UserName == body.UserName);
                if (TaiKhoan == null)
                {
                    return View();
                }
                else
                {
                    var claims = new List<Claim>() {
                    new Claim(ClaimTypes.NameIdentifier,TaiKhoan.UserName ),
                    new Claim(ClaimTypes.Name,TaiKhoan.UserName ),
                        new Claim(ClaimTypes.Role, TaiKhoan.Role.ToString()),
                };
                    //Initialize a new instance of the ClaimsIdentity with the claims and authentication scheme    
                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    //Initialize a new instance of the ClaimsPrincipal with ClaimsIdentity    
                    var principal = new ClaimsPrincipal(identity);
                    //SignInAsync is a Extension method for Sign in a principal for the specified scheme.    
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, new AuthenticationProperties());
                   if(TaiKhoan.Role==1)
                    {
                        return RedirectToAction("Index", "HomeAdmin");
                    }
                   else
                    {
                        return LocalRedirect("/");
                    }
                }
            }
            return View();
        }

        [Route("dang-nhap-voi-google")]
        public async Task LoginWithGoogle()
        {

            //var ExternalLogins = (await SignInManager<IdentityUser>.GetExternalAuthenticationSchemesAsync()).ToList();
            //var listprovider = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            //var provider_process = listprovider.Find((m) => m.Name == provider);
            //if (provider_process == null)
            //{
            //    return NotFound("Dịch vụ không chính xác: " + provider);
            //}

            //// redirectUrl - là Url sẽ chuyển hướng đến - sau khi CallbackPath (/dang-nhap-tu-google) thi hành xong
            //// nó bằng identity/account/externallogin?handler=Callback
            //// tức là gọi OnGetCallbackAsync
            //var redirectUrl = Url.Page("./ExternalLogin", pageHandler: "Callback", values: new { returnUrl });

            //// Cấu hình
            //var properties = _signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);

            //// Chuyển hướng đến dịch vụ ngoài (Googe, Facebook)
            var props = new AuthenticationProperties{ RedirectUri=Url.Action("GoogleResponse") };
            await HttpContext.ChallengeAsync(GoogleDefaults.AuthenticationScheme, props);
        }
        [Route("google-response")]
        public async Task<IActionResult> GoogleResponse()
        {
            var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var userName = HttpContext.User.FindFirst(ClaimTypes.Name)?.Value;
            var res = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);
           if(userId is not null)
            {
                var TaiKhoan = await _context.Taikhoans.FirstOrDefaultAsync(x => x.UserName == userId);
                if (TaiKhoan == null)
                {
                    var KhachHang = new KhachHang();
                    KhachHang.TenKhachHang = userName;
                    _context.KhachHangs.Add(KhachHang);
                    var khSave = await _context.SaveChangesAsync();
                    if(khSave>0)
                    {
                        var account = new Taikhoan();
                        account.UserName = userId;
                        account.IdKh = KhachHang.IdKh;
                        _context.Taikhoans.Add(account);
                        try
                        {
                            await _context.SaveChangesAsync();
                            return LocalRedirect("/");
                        }
                        catch
                        {
                            return BadRequest();
                        }
                    }
                    else
                    {
                      return  BadRequest();
                    }


                }
                else
                {
                    return LocalRedirect("/");
                }
                  
                   
                }else
            {
                return LocalRedirect("/");
            }
             
            }
            
           
        
        [Route("dang-nhap-voi-facebook")]
        public async Task LoginWithFacebook()
        {

            //var ExternalLogins = (await SignInManager<IdentityUser>.GetExternalAuthenticationSchemesAsync()).ToList();
            //var listprovider = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            //var provider_process = listprovider.Find((m) => m.Name == provider);
            //if (provider_process == null)
            //{
            //    return NotFound("Dịch vụ không chính xác: " + provider);
            //}

            //// redirectUrl - là Url sẽ chuyển hướng đến - sau khi CallbackPath (/dang-nhap-tu-google) thi hành xong
            //// nó bằng identity/account/externallogin?handler=Callback
            //// tức là gọi OnGetCallbackAsync
            //var redirectUrl = Url.Page("./ExternalLogin", pageHandler: "Callback", values: new { returnUrl });

            //// Cấu hình
            //var properties = _signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);

            //// Chuyển hướng đến dịch vụ ngoài (Googe, Facebook)
            var props = new AuthenticationProperties { RedirectUri = Url.Action("FacebookResponse") };
            await HttpContext.ChallengeAsync(FacebookDefaults.AuthenticationScheme, props);
        }
        [Route("facebook-response")]
        public async Task<IActionResult> FacebookResponse()
        {
            
            var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var userName = HttpContext.User.FindFirst(ClaimTypes.Name)?.Value;
            var res = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            if (userId is not null)
            {
                var TaiKhoan = await _context.Taikhoans.FirstOrDefaultAsync(x => x.UserName == userId);
                if (TaiKhoan == null)
                {
                    var KhachHang = new KhachHang();
                    KhachHang.TenKhachHang = userName;
                    _context.KhachHangs.Add(KhachHang);
                    var khSave = await _context.SaveChangesAsync();
                    if (khSave > 0)
                    {
                        var account = new Taikhoan();
                        account.UserName = userId;
                        account.IdKh = KhachHang.IdKh;
                        _context.Taikhoans.Add(account);
                        try
                        {
                            await _context.SaveChangesAsync();
                            return LocalRedirect("/");
                        }
                        catch
                        {
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
                    return LocalRedirect("/");
                }


            }
            else
            {
                return LocalRedirect("/");
            }
        }
        [Route("dang-xuat")]
        public async Task<IActionResult> Logout()
        {
             await HttpContext.SignOutAsync();
            return LocalRedirect("/");
        }
    }
}
