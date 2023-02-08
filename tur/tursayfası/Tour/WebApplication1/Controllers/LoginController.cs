using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.sınıflar;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Mimar.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        [HttpGet]
        public IActionResult GirisYap()
        {

            return View();
        }

        public async Task<IActionResult> GirisYap(Login p)
        {
            var bilgiler = c.Logins.FirstOrDefault(x => x.KullaniciAdi == p.KullaniciAdi && x.Sifre == p.Sifre);
            if (bilgiler != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.KullaniciAdi)
                };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Turlar");
            }

            return View();
        }

    }
}
