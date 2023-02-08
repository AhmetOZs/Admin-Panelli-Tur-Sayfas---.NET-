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
    public class TurlarRUController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            List<bolgeRU> bolgeRUs = c.bolgeRUs.ToList();

            List<turdetayRU> turdetayRUs = c.turdetayRUs.ToList();
            var degerler = c.TurlarRUs.ToList();
            return View(degerler);
        }
        [HttpGet]
        [Authorize]
        public ActionResult TurlarEkle()
        {
            List<SelectListItem> deger1 = (from x in c.bolgeRUs.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.bolgeismi,
                                               Value = x.bolgeID.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;
            return View();
        }
        [HttpPost]
        [Authorize]
        public async Task<ActionResult> TurlarEkle(TurlarRU k, IFormFile fileImg)
        {

            if (fileImg != null)
            {

                if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads")))
                {
                    Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads"));
                }
                var konumdegeri3 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\uploads", fileImg.FileName);

                using (Stream fileStream = new FileStream(konumdegeri3, FileMode.Create))
                {
                    await fileImg.CopyToAsync(fileStream);
                }
                k.girisresim = "/uploads/" + fileImg.FileName;
            }


            c.TurlarRUs.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult TurlarSil(int id)
        {
            var ktg = c.TurlarRUs.Find(id);
            c.TurlarRUs.Remove(ktg);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult TurlarGetir(int id)
        {
            List<SelectListItem> deger1 = (from x in c.bolgeRUs.ToList() select new SelectListItem { Text = x.bolgeismi, Value = x.bolgeID.ToString() }).ToList();
            ViewBag.dgr1 = deger1;
            var referasdeger = c.TurlarRUs.Find(id);
            return View("TurlarGetir", referasdeger);
        }
        [HttpPost]
        [Authorize]
        public async Task<ActionResult> TurlarGüncelle(TurlarRU k, IFormFile fileImg)
        {
            var ktgr = c.TurlarRUs.Find(k.turID);
            if (fileImg != null)
            {

                if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads")))
                {
                    Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads"));
                }
                var konumdegeri = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\uploads", fileImg.FileName);

                using (Stream fileStream = new FileStream(konumdegeri, FileMode.Create))
                {
                    await fileImg.CopyToAsync(fileStream);
                }
                k.girisresim = "/uploads/" + fileImg.FileName;
                ktgr.girisresim = k.girisresim;
            }
            ktgr.bolgeID = k.bolgeID;

            ktgr.Bolgesicaklik = k.Bolgesicaklik;

            ktgr.sehir = k.sehir;
            ktgr.turismi = k.turismi;
            ktgr.turtarihi = k.turtarihi;

            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
