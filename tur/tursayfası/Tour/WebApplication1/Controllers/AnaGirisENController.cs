using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.sınıflar;

namespace WebApplication1.Controllers
{
    public class AnaGirisENController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var degerler = c.AnaGirisENs.ToList();
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
        public async Task<ActionResult> GirisEkle(AnaGirisEN k, IFormFile fileImg)
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
            
            c.AnaGirisENs.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult GirisSil(int id)
        {
            var ktg = c.AnaGirisENs.Find(id);
            c.AnaGirisENs.Remove(ktg);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult GirisGetir(int id)
        {
            var hizmetler = c.AnaGirisENs.Find(id);
            return View("GirisGetir", hizmetler);
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult> GirisGüncelle(AnaGirisEN k, IFormFile fileImg)
        {
            var ktgr = c.AnaGirisENs.Find(k.ID);
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
