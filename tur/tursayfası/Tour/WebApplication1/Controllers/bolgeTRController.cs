using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplication1.Models.sınıflar;

namespace WebApplication1.Controllers
{
    public class bolgeTRController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var degerler = c.bolgeTRs.ToList();
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

        public ActionResult bolgeEkle(bolgeTR k)
        {
            c.bolgeTRs.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult bolgeSil(int id)
        {
            var ktg = c.bolgeTRs.Find(id);
            c.bolgeTRs.Remove(ktg);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]

        public ActionResult bolgeGetir(int id)
        {
            var kategori = c.bolgeTRs.Find(id);
            return View("bolgeGetir", kategori);
        }
        [Authorize]
        public ActionResult bolgeGüncelle(bolgeTR k)
        {
            var ktgr = c.bolgeTRs.Find(k.bolgeID);
            ktgr.bolgeismi = k.bolgeismi;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}


