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
    public class DetayGorselRUController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index(int id)
        {
            var degerler = c.detayGorselRUs.Where(x => x.turID == id).ToList();

            return View(degerler);
        }
        [HttpGet]
        [Authorize]
        public IActionResult DetayGorselEkle()
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
        public async Task<ActionResult> DetayGorselEkle(DetayGorselRU k, IFormFile fileImg)
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
                k.DetayResim = "/uploads/" + fileImg.FileName;
            }


            c.detayGorselRUs.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index", "DetayGorselRU", new { id = k.turID });
        }
        [Authorize]
        public ActionResult DetayGorselSil(int id)
        {
            var detayGorsel = c.detayGorselRUs.Find(id);
            c.detayGorselRUs.Remove(detayGorsel);
            c.SaveChanges();
            return RedirectToAction("Index", "DetayGorselRU", new { id = detayGorsel.turID });
        }
        [Authorize]
        public ActionResult DetayGorselGetir(int id)
        {
            List<SelectListItem> deger1 = (from x in c.TurlarRUs.ToList() select new SelectListItem { Text = x.turismi, Value = x.turID.ToString() }).ToList();
            ViewBag.dgr1 = deger1;
            var detayGorsel = c.detayGorselRUs.Find(id);
            return View("DetayGorselGetir", detayGorsel);
        }
        [HttpPost]
        [Authorize]
        public async Task<ActionResult> DetayGorselGüncelle(DetayGorselRU k, IFormFile fileImg)
        {
            var ktgr = c.detayGorselRUs.Find(k.DetayGorselID);
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
                k.DetayResim = "/uploads/" + fileImg.FileName;
                ktgr.DetayResim = k.DetayResim;
            }



            ktgr.turID = k.turID;
            c.SaveChanges();
            return RedirectToAction("Index", "DetayGorselRU", new { id = ktgr.turID });
        }
    }
}
