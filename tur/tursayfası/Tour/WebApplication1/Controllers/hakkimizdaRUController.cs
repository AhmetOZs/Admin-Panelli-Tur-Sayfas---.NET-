using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplication1.Models.sınıflar;

namespace WebApplication1.Controllers
{
    public class hakkimizdaRUController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var degerler = c.hakkimizdaRUs.ToList();
            return View(degerler);
        }
        [Authorize]
        public IActionResult hakkimizdaGetir(int id)
        {
            var hakkimizdaen = c.hakkimizdaRUs.Find(id);
            return View("hakkimizdaGetir", hakkimizdaen);
        }
        [Authorize]
        public ActionResult hakkimizdaGüncelle(hakkimizdaRU k)
        {
            var ktgr = c.hakkimizdaRUs.Find(k.hakkimizdaID);
            ktgr.hakkimizdabaslik = k.hakkimizdabaslik;
            ktgr.hakkimizdaaciklama = k.hakkimizdaaciklama;
            ktgr.hakkimizdavideo = k.hakkimizdavideo;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
