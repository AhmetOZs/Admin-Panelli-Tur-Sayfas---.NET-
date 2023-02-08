using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplication1.Models.sınıflar;

namespace WebApplication1.Controllers
{
    public class IletisimController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var degerler = c.iletisims.ToList();
            return View(degerler);
        }
        [Authorize]
        public IActionResult IletisimGetir(int id)
        {
            var iletisim = c.iletisims.Find(id);
            return View("IletisimGetir", iletisim);
        }
        [Authorize]
        public ActionResult IletisimGüncelle(Iletisim k)
        {
            var ktgr = c.iletisims.Find(k.iletisimID);
            ktgr.telefonsabit = k.telefonsabit;
            ktgr.telefoncep = k.telefoncep;
            ktgr.mail = k.mail;
            ktgr.adres = k.adres;
            ktgr.konum = k.konum;
            ktgr.facebook = k.facebook;
            ktgr.twitter = k.twitter;
            ktgr.instagram = k.instagram;
            ktgr.linkedin = k.linkedin;
            ktgr.metintr = k.metintr;
            ktgr.metinen = k.metinen;
            ktgr.metinru = k.metinru;
            ktgr.fotaciklamatr = k.fotaciklamatr;
            ktgr.fotaciklamaen = k.fotaciklamaen;
            ktgr.fotaciklamaru = k.fotaciklamaru;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
