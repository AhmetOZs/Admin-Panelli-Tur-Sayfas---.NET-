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
    public class DetayGorselTRController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index(int id)
        {
            var degerler = c.detayGorselTRs.Where(x => x.turID == id).ToList();

            return View(degerler);
        }
        [HttpGet]
        [Authorize]
        public IActionResult DetayGorselEkle()
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
        public async Task<ActionResult> DetayGorselEkle(DetayGorselTR k, IFormFile fileImg)
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


            c.detayGorselTRs.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index", "DetayGorselTR", new { id = k.turID });
        }
        [Authorize]
        public ActionResult DetayGorselSil(int id)
        {
            var detayGorsel = c.detayGorselTRs.Find(id);
            c.detayGorselTRs.Remove(detayGorsel);
            c.SaveChanges();
            return RedirectToAction("Index", "DetayGorselTR", new { id = detayGorsel.turID });
        }
        [Authorize]
        public ActionResult DetayGorselGetir(int id)
        {
            List<SelectListItem> deger1 = (from x in c.TurlarTRs.ToList() select new SelectListItem { Text = x.turismi, Value = x.turID.ToString() }).ToList();
            ViewBag.dgr1 = deger1;
            var detayGorsel = c.detayGorselTRs.Find(id);
            return View("DetayGorselGetir", detayGorsel);
        }
        [HttpPost]
        [Authorize]

        public async Task<ActionResult> DetayGorselGüncelle(DetayGorselTR k, IFormFile fileImg)
        {
            var ktgr = c.detayGorselTRs.Find(k.DetayGorselID);
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
            return RedirectToAction("Index", "DetayGorselTR", new { id = ktgr.turID });
        }
    }
}
