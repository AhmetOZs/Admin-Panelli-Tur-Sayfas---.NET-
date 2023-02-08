using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models.sınıflar;

namespace WebApplication1.Controllers
{
    public class bolgeController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var degerler = c.bolges.ToList();
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
        public ActionResult bolgeEkle(bolge k)
        {
            c.bolges.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult bolgeSil(int id)
        {
            var ktg = c.bolges.Find(id);
            c.bolges.Remove(ktg);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult bolgeGetir(int id)
        {
            var kategori = c.bolges.Find(id);
            return View("bolgeGetir", kategori);
        }
        [Authorize]
        public ActionResult bolgeGüncelle(bolge k)
        {
            var ktgr = c.bolges.Find(k.bolgeID);
            ktgr.bolgeismi = k.bolgeismi;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
