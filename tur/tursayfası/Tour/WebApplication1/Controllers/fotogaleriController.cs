using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.sınıflar;

namespace WebApplication1.Controllers
{
    public class fotogaleriController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var a = c.fotogaleris.ToList();
            return View(a);
        }
        [HttpGet]
        [Authorize]
        public ActionResult GaleriEkle()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public async Task<ActionResult> GaleriEkle(fotogaleri k, IFormFile fileImg)
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
                k.galeriResim = "/uploads/" + fileImg.FileName;
            }


            c.fotogaleris.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult GaleriSil(int id)
        {
            var ktg = c.fotogaleris.Find(id);
            c.fotogaleris.Remove(ktg);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult GaleriGetir(int id)
        {
            var fotogaleri = c.fotogaleris.Find(id);
            return View("GaleriGetir", fotogaleri);
        }
        [Authorize]
        [HttpPost]
        public async Task<ActionResult> GaleriGüncelle(fotogaleri k, IFormFile fileImg)
        {
            var ktgr = c.fotogaleris.Find(k.galeriID);
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
                k.galeriResim = "/uploads/" + fileImg.FileName;
                ktgr.galeriResim = k.galeriResim;
            }
         
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
