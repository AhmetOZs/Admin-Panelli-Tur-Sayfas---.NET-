using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.sınıflar;

namespace WebApplication1.Controllers
{
    public class AnaController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var degerler = c.Anas.ToList();
            return View(degerler);
        }
   
        public ActionResult AnaGetir(int id)
        {
            var hizmetler = c.Anas.Find(id);
            return View("AnaGetir", hizmetler);
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult> AnaGüncelle(Ana k, IFormFile fileImg, IFormFile fileImg2, IFormFile fileImg3)
        {
            var ktgr = c.Anas.Find(k.ID);
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
                k.TurlarKucukResim = "/uploads/" + fileImg.FileName;
                ktgr.TurlarKucukResim = k.TurlarKucukResim;
            }
            if (fileImg2 != null)
            {

                if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads")))
                {
                    Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads"));
                }
                var konumdegeri2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\uploads", fileImg2.FileName);

                using (Stream fileStream2 = new FileStream(konumdegeri2, FileMode.Create))
                {
                    await fileImg2.CopyToAsync(fileStream2);
                }
                k.YorumArkaResim = "/uploads/" + fileImg2.FileName;
                ktgr.YorumArkaResim = k.YorumArkaResim;
            }
            if (fileImg3 != null)
            {

                if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads")))
                {
                    Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads"));
                }
                var konumdegeri3 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\uploads", fileImg3.FileName);

                using (Stream fileStream3 = new FileStream(konumdegeri3, FileMode.Create))
                {
                    await fileImg3.CopyToAsync(fileStream3);
                }
                k.HakkimdaArkaResim = "/uploads/" + fileImg3.FileName;
                ktgr.HakkimdaArkaResim = k.HakkimdaArkaResim;
            }


            ktgr.TurlarAcıklamaTR = k.TurlarAcıklamaTR;
            ktgr.GaleriAcıklamaTR = k.GaleriAcıklamaTR;
            ktgr.TurlarAcıklamaEn = k.TurlarAcıklamaEn;
            ktgr.GaleriAcıklamaEn = k.GaleriAcıklamaEn;
            ktgr.TurlarAcıklamaRU = k.TurlarAcıklamaRU;
            ktgr.GaleriAcıklamaRU = k.GaleriAcıklamaRU;

           

            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
