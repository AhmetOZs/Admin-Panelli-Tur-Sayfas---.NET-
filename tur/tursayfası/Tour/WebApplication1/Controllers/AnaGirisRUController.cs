using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.sınıflar;

namespace WebApplication1.Controllers
{
    public class AnaGirisRUController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var degerler = c.AnaGirisRUs.ToList();
            return View(degerler);
        }
        [HttpGet]
        [Authorize]
        public ActionResult GirisEkle()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public async Task<ActionResult> GirisEkle(AnaGirisRU k, IFormFile fileImg)
        {

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
                k.arkaplan = "/uploads/" + fileImg.FileName;
            }

            c.AnaGirisRUs.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult GirisSil(int id)
        {
            var ktg = c.AnaGirisRUs.Find(id);
            c.AnaGirisRUs.Remove(ktg);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult GirisGetir(int id)
        {
            var hizmetler = c.AnaGirisRUs.Find(id);
            return View("GirisGetir", hizmetler);
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult> GirisGüncelle(AnaGirisRU k, IFormFile fileImg)
        {
            var ktgr = c.AnaGirisRUs.Find(k.ID);
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
                k.arkaplan = "/uploads/" + fileImg.FileName;
                ktgr.arkaplan = k.arkaplan;
            }



            ktgr.üstsatır = k.üstsatır;

            ktgr.yer = k.yer;
            ktgr.altsatır = k.altsatır;
            ktgr.ucret = k.ucret;

            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
