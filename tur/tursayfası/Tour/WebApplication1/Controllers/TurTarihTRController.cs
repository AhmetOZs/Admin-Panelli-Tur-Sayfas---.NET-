using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models.sınıflar;

namespace WebApplication1.Controllers
{
    public class TurTarihTRController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index(int id)
        {
            var degerler = c.turTarihTRs.Where(x => x.turID == id).ToList();

            return View(degerler);
        }
        [HttpGet]
        [Authorize]
        public IActionResult TarihEkle()
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
        public ActionResult TarihEkle(TurTarihTR k, int id)
        {
            var turdetay = c.turTarihTRs.Find(id);
            c.turTarihTRs.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index", "TurTarihTR", new { id = k.turID });
        }
        [Authorize]
        public ActionResult TarihSil(int id)
        {
            var turdetay = c.turTarihTRs.Find(id);
            c.turTarihTRs.Remove(turdetay);
            c.SaveChanges();
            return RedirectToAction("Index", "TurTarihTR", new { id = turdetay.turID });
        }
        [Authorize]
        public IActionResult TarihGetir(int id)
        {
            var turdetay = c.turTarihTRs.Find(id);
            return View("TarihGetir", turdetay);
        }
        [Authorize]
        public ActionResult TarihGüncelle(TurTarihTR k)
        {
            var ktgr = c.turTarihTRs.Find(k.tarihID);
            ktgr.tarih = k.tarih;

            c.SaveChanges();
            return RedirectToAction("Index", "TurTarihTR", new { id = ktgr.turID });
        }
    }
}
