using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplication1.Models.sınıflar;

namespace WebApplication1.Controllers
{
    public class hakkimizdaTRController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var degerler = c.hakkimizdaTRs.ToList();
            return View(degerler);
        }
        [Authorize]
        public IActionResult hakkimizdaGetir(int id)
        {
            var hakkimizdaen = c.hakkimizdaTRs.Find(id);
            return View("hakkimizdaGetir", hakkimizdaen);
        }
        [Authorize]
        public ActionResult hakkimizdaGüncelle(hakkimizdaTR k)
        {
            var ktgr = c.hakkimizdaTRs.Find(k.hakkimizdaID);
            ktgr.hakkimizdabaslik = k.hakkimizdabaslik;
            ktgr.hakkimizdaaciklama = k.hakkimizdaaciklama;
            ktgr.hakkimizdavideo = k.hakkimizdavideo;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
