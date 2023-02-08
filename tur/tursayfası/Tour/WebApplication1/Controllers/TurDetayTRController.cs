using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models.sınıflar;

namespace WebApplication1.Controllers
{
    public class TurDetayTRController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index(int id)
        {
            var degerler = c.turdetayTRs.Where(x => x.turID == id).ToList();

            return View(degerler);
        }
        [HttpGet]
        [Authorize]
        public IActionResult AciklamaEkle()
        {
            List<SelectListItem> deger1 = (from x in c.TurlarTRs.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.turismi,
                                               Value = x.turID.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;
            return View();
        }


        [HttpPost]
        [Authorize]

        public ActionResult AciklamaEkle(turdetayTR k, int id)
        {
            var turdetay = c.turdetayTRs.Find(id);
            c.turdetayTRs.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index", "TurDetayTR", new { id = k.turID });
        }
        [Authorize]
        public ActionResult AciklamaSil(int id)
        {
            var turdetay = c.turdetayTRs.Find(id);
            c.turdetayTRs.Remove(turdetay);
            c.SaveChanges();
            return RedirectToAction("Index", "TurDetayTR", new { id = turdetay.turID });
        }
        [Authorize]
        public IActionResult AciklamaGetir(int id)
        {
            var turdetay = c.turdetayTRs.Find(id);
            return View("AciklamaGetir", turdetay);
        }
        [Authorize]
        public ActionResult AciklamaGüncelle(turdetayTR k)
        {
            var ktgr = c.turdetayTRs.Find(k.detayID);
            ktgr.detaybaslik = k.detaybaslik;
            ktgr.detayaciklama = k.detayaciklama;
            c.SaveChanges();
            return RedirectToAction("Index", "TurDetayTR", new { id = ktgr.turID });
        }
    }
}
