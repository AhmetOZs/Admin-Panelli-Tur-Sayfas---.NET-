using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.sınıflar;

namespace WebApplication1.Controllers
{
    public class TurDetayController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index(int id)
        {
            var degerler = c.turdetays.Where(x => x.turID == id).ToList();
           
            return View(degerler);
        }
        [HttpGet]
        [Authorize]
        public IActionResult AciklamaEkle()
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

        public ActionResult AciklamaEkle(turdetay k,int id)
        {
            var turdetay = c.turdetays.Find(id);
            c.turdetays.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index","TurDetay",new {id=k.turID});
        }
        [Authorize]
        public ActionResult AciklamaSil(int id)
        {
            var turdetay = c.turdetays.Find(id);
            c.turdetays.Remove(turdetay);
            c.SaveChanges();
            return RedirectToAction("Index", "TurDetay", new { id = turdetay.turID });
        }
        [Authorize]
        public IActionResult AciklamaGetir(int id)
        {
            var turdetay = c.turdetays.Find(id);
            return View("AciklamaGetir", turdetay);
        }
        [Authorize]
        public ActionResult AciklamaGüncelle(turdetay k)
        {
            var ktgr = c.turdetays.Find(k.detayID);
            ktgr.detaybaslik = k.detaybaslik;
            ktgr.detayaciklama = k.detayaciklama;
            c.SaveChanges();
            return RedirectToAction("Index", "TurDetay", new { id = ktgr.turID });
        }
    }
}
