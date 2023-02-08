using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models.sınıflar;

namespace WebApplication1.Controllers
{
    public class hizmetRUController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index(int id)
        {
            var degerler = c.hizmetRUs.Where(x => x.turID == id).ToList();

            return View(degerler);
        }
        [HttpGet]
        [Authorize]
        public IActionResult HizmetEkle()
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

        public ActionResult HizmetEkle(hizmetRU k, int id)
        {
            var hizmet = c.hizmetRUs.Find(id);
            c.hizmetRUs.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index", "hizmetRU", new { id = k.turID });
        }
        [Authorize]
        public ActionResult HizmetSil(int id)
        {
            var hizmet = c.hizmetRUs.Find(id);
            c.hizmetRUs.Remove(hizmet);
            c.SaveChanges();
            return RedirectToAction("Index", "hizmetRU", new { id = hizmet.turID });
        }
        [Authorize]
        public IActionResult HizmetGetir(int id)
        {
            var hizmet = c.hizmetRUs.Find(id);
            return View("HizmetGetir", hizmet);
        }
        [Authorize]
        public ActionResult HizmetGüncelle(hizmetRU k)
        {
            var ktgr = c.hizmetRUs.Find(k.hizmetID);
            ktgr.hizmetad = k.hizmetad;
            ktgr.hizmetaciklama = k.hizmetaciklama;
            ktgr.ucret = k.ucret;
            c.SaveChanges();
            return RedirectToAction("Index", "hizmetRU", new { id = ktgr.turID });
        }
    }
}
