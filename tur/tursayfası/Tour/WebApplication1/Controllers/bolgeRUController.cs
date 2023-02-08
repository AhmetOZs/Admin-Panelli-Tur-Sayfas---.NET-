using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplication1.Models.sınıflar;

namespace WebApplication1.Controllers
{
    public class bolgeRUController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var degerler = c.bolgeRUs.ToList();
            return View(degerler);
        }
        [HttpGet]
        [Authorize]

        public ActionResult bolgeEkle()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public ActionResult bolgeEkle(bolgeRU k)
        {
            c.bolgeRUs.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult bolgeSil(int id)
        {
            var ktg = c.bolgeRUs.Find(id);
            c.bolgeRUs.Remove(ktg);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult bolgeGetir(int id)
        {
            var kategori = c.bolgeRUs.Find(id);
            return View("bolgeGetirRU", kategori);
        }
        [Authorize]
        public ActionResult bolgeGüncelle(bolgeRU k)
        {
            var ktgr = c.bolgeRUs.Find(k.bolgeID);
            ktgr.bolgeismi = k.bolgeismi;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
