using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.sınıflar;

namespace WebApplication1.Controllers
{
    public class YorumController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var degerler = c.yorums.ToList();
            return View(degerler);
        }
        [HttpGet]
        [Authorize]

        public ActionResult YorumEkle()
        {
            return View();
        }
        [HttpPost]
        [Authorize]

        public async Task<ActionResult> YorumEkle(Yorum k, IFormFile fileImg, IFormFile fileImg2)
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
                k.resim = "/uploads/" + fileImg.FileName;
            }
           
            c.yorums.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult YorumSil(int id)
        {
            var ktg = c.yorums.Find(id);
            c.yorums.Remove(ktg);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult YorumGetir(int id)
        {
            var hizmetler = c.yorums.Find(id);
            return View("YorumGetir", hizmetler);
        }

        [HttpPost]
        [Authorize]

        public async Task<ActionResult> YorumGüncelle(Yorum k, IFormFile fileImg, IFormFile fileImg2)
        {
            var ktgr = c.yorums.Find(k.YorumID);
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
                k.resim = "/uploads/" + fileImg.FileName;
                ktgr.resim = k.resim;
            }
           


            ktgr.tur = k.tur;

            ktgr.ad = k.ad;
            ktgr.soyad = k.soyad;
            ktgr.yorum = k.yorum;
            ktgr.puan = k.puan;

            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
