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
    public class DetayGorselController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index(int id)
        {
            var degerler = c.detayGorsels.Where(x => x.turID == id).ToList();

            return View(degerler);
        }
        [HttpGet]
        public IActionResult DetayGorselEkle()
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

        public async Task<ActionResult> DetayGorselEkle(DetayGorsel k, IFormFile fileImg)
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


            c.detayGorsels.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index", "DetayGorsel", new { id = k.turID });
        }
        [Authorize]
        public ActionResult DetayGorselSil(int id)
        {
            var detayGorsel = c.detayGorsels.Find(id);
            c.detayGorsels.Remove(detayGorsel);
            c.SaveChanges();
            return RedirectToAction("Index", "DetayGorsel", new { id = detayGorsel.turID });
        }
        [Authorize]
        public ActionResult DetayGorselGetir(int id)
        {
            List<SelectListItem> deger1 = (from x in c.Turlars.ToList() select new SelectListItem { Text = x.turismi, Value = x.turID.ToString() }).ToList();
            ViewBag.dgr1 = deger1;
            var detayGorsel = c.detayGorsels.Find(id);
            return View("DetayGorselGetir", detayGorsel);
        }
        [HttpPost]
        [Authorize]
        public async Task<ActionResult> DetayGorselGüncelle(DetayGorsel k, IFormFile fileImg)
        {
            var ktgr = c.detayGorsels.Find(k.DetayGorselID);
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
            return RedirectToAction("Index", "DetayGorsel", new { id = ktgr.turID });
        }

    }
}
