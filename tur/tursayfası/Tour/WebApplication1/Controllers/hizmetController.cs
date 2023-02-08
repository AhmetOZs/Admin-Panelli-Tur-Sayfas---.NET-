using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models.sınıflar;

namespace WebApplication1.Controllers
{
    public class hizmetController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index(int id)
        {
            var degerler = c.hizmets.Where(x => x.turID == id).ToList();

            return View(degerler);
        }
        [HttpGet]
        [Authorize]
        public IActionResult HizmetEkle()
        {
            List<SelectListItem> deger1 = (from x in c.Turlars.ToList()
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

        public ActionResult HizmetEkle(hizmet k, int id)
        {
            var hizmet = c.hizmets.Find(id);
            c.hizmets.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index", "hizmet", new { id = k.turID });
        }
        [Authorize]
        public ActionResult HizmetSil(int id)
        {
            var hizmet = c.hizmets.Find(id);
            c.hizmets.Remove(hizmet);
            c.SaveChanges();
            return RedirectToAction("Index", "hizmet", new { id = hizmet.turID });
        }
        [Authorize]
        public IActionResult HizmetGetir(int id)
        {
            var hizmet = c.hizmets.Find(id);
            return View("HizmetGetir", hizmet);
        }
        [Authorize]
        public ActionResult HizmetGüncelle(hizmet k)
        {
            var ktgr = c.hizmets.Find(k.hizmetID);
            ktgr.hizmetad = k.hizmetad;
            ktgr.hizmetaciklama = k.hizmetaciklama;
            ktgr.ucret = k.ucret;
            c.SaveChanges();
            return RedirectToAction("Index", "hizmet", new { id = ktgr.turID });
        }
    }
}
