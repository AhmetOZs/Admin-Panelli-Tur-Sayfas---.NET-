using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models.sınıflar;

namespace WebApplication1.Controllers
{
    public class TurTarihRUController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index(int id)
        {
            var degerler = c.turTarihRUs.Where(x => x.turID == id).ToList();

            return View(degerler);
        }
        [HttpGet]
        [Authorize]
        public IActionResult TarihEkle()
        {
            List<SelectListItem> deger1 = (from x in c.TurlarRUs.ToList()
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

        public ActionResult TarihEkle(TurTarihRU k, int id)
        {
            var turdetay = c.turTarihRUs.Find(id);
            c.turTarihRUs.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index", "TurTarihRU", new { id = k.turID });
        }
        [Authorize]
        public ActionResult TarihSil(int id)
        {
            var turdetay = c.turTarihRUs.Find(id);
            c.turTarihRUs.Remove(turdetay);
            c.SaveChanges();
            return RedirectToAction("Index", "TurTarihRU", new { id = turdetay.turID });
        }
        [Authorize]
        public IActionResult TarihGetir(int id)
        {
            var turdetay = c.turTarihRUs.Find(id);
            return View("TarihGetir", turdetay);
        }
        [Authorize]
        public ActionResult TarihGüncelle(TurTarihRU k)
        {
            var ktgr = c.turTarihRUs.Find(k.tarihID);
            ktgr.tarih = k.tarih;

            c.SaveChanges();
            return RedirectToAction("Index", "TurTarihRU", new { id = ktgr.turID });
        }
    }
}
