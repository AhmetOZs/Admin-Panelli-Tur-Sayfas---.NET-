using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.sınıflar;

namespace WebApplication1.Controllers
{
    public class AnasayfaController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            List<AnaGirisTR> giris = new();
            giris = c.AnaGirisTRs.ToList();
            ViewBag.giris = giris;

            List<Ana> anas = new();
            anas = c.Anas.ToList();
            ViewBag.ana = anas;

            List<bolgeTR> bolges = new();
            bolges = c.bolgeTRs.ToList();
            ViewBag.bolge = bolges;

            List<TurTarihTR> turTarihs = new();
            turTarihs = c.turTarihTRs.ToList();
            ViewBag.tarih = turTarihs;


            List<hakkimizdaTR> hakkimizdaens = new();
            hakkimizdaens = c.hakkimizdaTRs.ToList();
            ViewBag.hakkimdaen = hakkimizdaens;

            List<fotogaleri> fotogaleris = new();
            fotogaleris = c.fotogaleris.ToList();
            ViewBag.galeri = fotogaleris;
            List<Iletisim> iletisims = new();
            iletisims = c.iletisims.ToList();
            ViewBag.iletisim = iletisims;
            List<Yorum> yorums = new();
            yorums = c.yorums.ToList();
            ViewBag.yorum = yorums;
            var degerler = c.TurlarTRs.ToList();
            //

            List<bolgeTR> bolgeList = c.bolgeTRs.ToList();


            return View(degerler);

        }
        public IActionResult IndexEn()
        {
            List<AnaGirisEN> giris = new();
            giris = c.AnaGirisENs.ToList();
            ViewBag.giris = giris;

            List<Ana> anas = new();
            anas = c.Anas.ToList();
            ViewBag.ana = anas;

            List<bolge> bolges = new();
            bolges = c.bolges.ToList();
            ViewBag.bolge = bolges;

            List<hakkimizdaen> hakkimizdaens = new();
            hakkimizdaens = c.hakkimizdaens.ToList();
            ViewBag.hakkimdaen = hakkimizdaens;

            List<fotogaleri> fotogaleris = new();
            fotogaleris = c.fotogaleris.ToList();
            ViewBag.galeri = fotogaleris;
            List<Iletisim> iletisims = new();
            iletisims = c.iletisims.ToList();
            ViewBag.iletisim = iletisims;
            List<Yorum> yorums = new();
            yorums = c.yorums.ToList();
            ViewBag.yorum = yorums;
            var degerler = c.Turlars.ToList();
            //

            List<bolge> bolgeList = c.bolges.ToList();
            

            return View(degerler);


           
        }
        public IActionResult IndexRu()
        {
            List<AnaGirisRU> giris = new();
            giris = c.AnaGirisRUs.ToList();
            ViewBag.giris = giris;

            List<Ana> anas = new();
            anas = c.Anas.ToList();
            ViewBag.ana = anas;

            List<bolgeRU> bolges = new();
            bolges = c.bolgeRUs.ToList();
            ViewBag.bolge = bolges;

            List<hakkimizdaRU> hakkimizdaens = new();
            hakkimizdaens = c.hakkimizdaRUs.ToList();
            ViewBag.hakkimdaen = hakkimizdaens;

            List<fotogaleri> fotogaleris = new();
            fotogaleris = c.fotogaleris.ToList();
            ViewBag.galeri = fotogaleris;
            List<Iletisim> iletisims = new();
            iletisims = c.iletisims.ToList();
            ViewBag.iletisim = iletisims;
            List<Yorum> yorums = new();
            yorums = c.yorums.ToList();
            ViewBag.yorum = yorums;
            var degerler = c.TurlarRUs.ToList();
            //

            List<bolgeRU> bolgeList = c.bolgeRUs.ToList();


            return View(degerler);
        }
        public IActionResult Iletisim()
        {
            List<Iletisim> iletisims = new();
            iletisims = c.iletisims.ToList();
            ViewBag.iletisim = iletisims;
            return View();
        }
        public IActionResult IletisimEn()
        {
            List<Iletisim> iletisims = new();
            iletisims = c.iletisims.ToList();
            ViewBag.iletisim = iletisims;
            return View();
        }
        public IActionResult IletisimRu()
        {
            List<Iletisim> iletisims = new();
            iletisims = c.iletisims.ToList();
            ViewBag.iletisim = iletisims;
            return View();
        }
        public IActionResult TurDetay(int id)
        {
            List<TurlarTR> turlars = new();

            var detayGorsels = c.detayGorselTRs.Where(x => x.turID == id).ToList();
            ViewBag.gorsel = detayGorsels;
            var turdetay = c.turdetayTRs.Where(x => x.turID == id).ToList();
            ViewBag.detay = turdetay;
            ViewBag.detays = turlars;
            var hizmets = c.hizmetTRs.Where(x => x.turID == id).ToList();
            ViewBag.hizmet = hizmets;
            var tarih = c.turTarihTRs.Where(x => x.turID == id).ToList();
            ViewBag.tarih = tarih;
            var turlar = c.TurlarTRs.Find(id == 0 ? turlars[0].turID : id);
            ViewBag.turlar = turlar;

            //
            List<Iletisim> iletisims = new();
            iletisims = c.iletisims.ToList();
            ViewBag.iletisim = iletisims;
            return View();
        }
        [HttpPost]
        public IActionResult TurDetay(string date, string adults, int id)

        {

            if (!string.IsNullOrEmpty(date))
            {
                List<TurlarTR> turlars = c.TurlarTRs.Where(x => x.turID == id).ToList();


                List<TurTarihTR> turTarihList = c.turTarihTRs.Where(x => x.tarih == date).ToList();

                turlars = c.turTarihTRs.Where(x => x.tarih == date && x.turID == id)
                                     .Select(y => y.TurlarTR)
                                     .ToList();


                var detayGorsels = c.detayGorselTRs.Where(x => x.turID == id).ToList();
                ViewBag.gorsel = detayGorsels;
                var turdetay = c.turdetayTRs.Where(x => x.turID == id).ToList();
                ViewBag.detay = turdetay;
                ViewBag.detays = turlars;
                ViewBag.turlar = (turlars.Count != 0) ? turlars[0] : new TurlarTR();
                List<Iletisim> iletisims = new();
                iletisims = c.iletisims.ToList();
                ViewBag.iletisim = iletisims;

                return View(turlars);


            }
            else
            {

                var detayGorsels = c.detayGorselTRs.Where(x => x.turID == id).ToList();
                ViewBag.gorsel = detayGorsels;
                var turdetay = c.turdetayTRs.Where(x => x.turID == id).ToList();
                ViewBag.detay = turdetay;



                List<Iletisim> iletisims = new();
                iletisims = c.iletisims.ToList();
                ViewBag.iletisim = iletisims;

                return View();
            }


        }
        public IActionResult TurDetayEn(int id)
        {
            List<Turlar> turlars = new();

            var detayGorsels = c.detayGorsels.Where(x => x.turID == id).ToList();
            ViewBag.gorsel = detayGorsels;
            var turdetay = c.turdetays.Where(x=> x.turID == id).ToList();
            ViewBag.detay = turdetay;
            ViewBag.detays = turlars;
            var hizmets = c.hizmets.Where(x => x.turID == id).ToList();
            ViewBag.hizmet = hizmets;
            var tarih = c.turTarihs.Where(x => x.turID == id).ToList();
            ViewBag.tarih = tarih;
            var turlar = c.Turlars.Find(id == 0 ? turlars[0].turID : id);
            ViewBag.turlar = turlar;
            //
            List<Iletisim> iletisims = new();
            iletisims = c.iletisims.ToList();
            ViewBag.iletisim = iletisims;
            return View();

           
        }
        [HttpPost]
        public IActionResult TurDetayEn(string date, string adults, int id)

        {
            
            if (!string.IsNullOrEmpty(date))
            {
                List<Turlar> turlars = c.Turlars.Where(x => x.turID == id).ToList();


                List<TurTarih> turTarihList = c.turTarihs.Where(x => x.tarih == date).ToList();

                turlars = c.turTarihs.Where(x => x.tarih == date && x.turID == id)   
                                     .Select(y=> y.Turlar)
                                     .ToList();

                
                var detayGorsels = c.detayGorsels.Where(x => x.turID == id).ToList();
                ViewBag.gorsel = detayGorsels;
                var turdetay = c.turdetays.Where(x => x.turID == id).ToList();
                ViewBag.detay = turdetay;
                ViewBag.detays = turlars;
                ViewBag.turlar = (turlars.Count != 0) ? turlars[0] : new Turlar();
                List<Iletisim> iletisims = new();
                iletisims = c.iletisims.ToList();
                ViewBag.iletisim = iletisims;

                return View(turlars);


            }
            else
            {

                var detayGorsels = c.detayGorsels.Where(x => x.turID == id).ToList();
                ViewBag.gorsel = detayGorsels;
                var turdetay = c.turdetays.Where(x => x.turID == id).ToList();
                ViewBag.detay = turdetay;
               
                
                              
                List<Iletisim> iletisims = new();
                iletisims = c.iletisims.ToList();
                ViewBag.iletisim = iletisims;
                
                return View();
            }


        }

        public IActionResult TurDetayRu(int id)
        {
            List<TurlarRU> turlars = new();

            var detayGorsels = c.detayGorselRUs.Where(x => x.turID == id).ToList();
            ViewBag.gorsel = detayGorsels;
            var turdetay = c.turdetayRUs.Where(x => x.turID == id).ToList();
            ViewBag.detay = turdetay;
            ViewBag.detays = turlars;
            var hizmets = c.hizmetRUs.Where(x => x.turID == id).ToList();
            ViewBag.hizmet = hizmets;
            var turlar = c.TurlarRUs.Find(id == 0 ? turlars[0].turID : id);
            ViewBag.turlar = turlar;
            var tarih = c.turTarihRUs.Where(x => x.turID == id).ToList();
            ViewBag.tarih = tarih;
            //
            List<Iletisim> iletisims = new();
            iletisims = c.iletisims.ToList();
            ViewBag.iletisim = iletisims;
            return View();

        }
        [HttpPost]
        public IActionResult TurDetayRU(string date, string adults, int id)

        {

            if (!string.IsNullOrEmpty(date))
            {
                List<TurlarRU> turlars = c.TurlarRUs.Where(x => x.turID == id).ToList();


                List<TurTarihRU> turTarihList = c.turTarihRUs.Where(x => x.tarih == date).ToList();

                turlars = c.turTarihRUs.Where(x => x.tarih == date && x.turID == id)
                                     .Select(y => y.TurlarRU)
                                     .ToList();


                var detayGorsels = c.detayGorselRUs.Where(x => x.turID == id).ToList();
                ViewBag.gorsel = detayGorsels;
                var turdetay = c.turdetayRUs.Where(x => x.turID == id).ToList();
                ViewBag.detay = turdetay;
                ViewBag.detays = turlars;
                ViewBag.turlar = (turlars.Count != 0) ? turlars[0] : new TurlarRU();
                List<Iletisim> iletisims = new();
                iletisims = c.iletisims.ToList();
                ViewBag.iletisim = iletisims;

                return View(turlars);


            }
            else
            {

                var detayGorsels = c.detayGorselRUs.Where(x => x.turID == id).ToList();
                ViewBag.gorsel = detayGorsels;
                var turdetay = c.turdetayRUs.Where(x => x.turID == id).ToList();
                ViewBag.detay = turdetay;



                List<Iletisim> iletisims = new();
                iletisims = c.iletisims.ToList();
                ViewBag.iletisim = iletisims;

                return View();
            }


        }
        public IActionResult Turlar()
        {
            List<bolgeTR> bolgeList = c.bolgeTRs.ToList();
            List<Iletisim> iletisims = new();
            iletisims = c.iletisims.ToList();
            ViewBag.iletisim = iletisims;
            var degerler = c.TurlarTRs.ToList();
            List<bolgeTR> bolges = new();
            bolges = c.bolgeTRs.ToList();
            ViewBag.bolge = bolges;
            List<TurTarihTR> turTarihs = new();
            turTarihs = c.turTarihTRs.ToList();
            ViewBag.tarih = turTarihs;
            return View(degerler);

        }
        [HttpPost]
        public IActionResult Turlar(string search, string date, string adults)
        {
            if (!string.IsNullOrEmpty(search))
            {
                List<TurlarTR> turList = c.TurlarTRs.Where(x => x.bolgeTR.bolgeismi == search).ToList();
                List<TurTarihTR> turTarihList = c.turTarihTRs.Where(x => x.tarih == date).ToList();
                List<TurlarTR> newlist = new();
                if (!string.IsNullOrEmpty(date)) { 
                
                    foreach (var item in turList)
                    {
                   
                        foreach (var turTarih in turTarihList)
                        {
                            if (turTarih.turID == item.turID)
                            {
                                newlist.Add(item);
                            }
                        }
                    }
                }
                else
                {
                    newlist = turList;
                }
                List<bolgeTR> bolges = new();
                bolges = c.bolgeTRs.ToList();
                ViewBag.bolge = bolges;
                List<Iletisim> iletisims = new();
                iletisims = c.iletisims.ToList();
                ViewBag.iletisim = iletisims;

                return View(newlist);


            }
            else
            {
                List<bolgeTR> bolges = new();
                bolges = c.bolgeTRs.ToList();
                ViewBag.bolge = bolges;
                List<Iletisim> iletisims = new();
                iletisims = c.iletisims.ToList();
                ViewBag.iletisim = iletisims;
                var degerler = c.TurlarTRs.ToList();
                return View(degerler);
            }


        }
        public IActionResult TurlarEn()
        {
            List<bolge> bolgeList = c.bolges.ToList();
            List<Iletisim> iletisims = new();
            iletisims = c.iletisims.ToList();
            ViewBag.iletisim = iletisims;
            var degerler = c.Turlars.ToList();
            List<bolge> bolges = new();
            bolges = c.bolges.ToList();
            ViewBag.bolge = bolges;
            return View(degerler);

        }
        [HttpPost]
        public IActionResult TurlarEn(string search, string date, string adults) 
        {
            if (!string.IsNullOrEmpty(search))
            {
                List<Turlar> turList = c.Turlars.Where(x => x.Bolge.bolgeismi == search).ToList();
                List<TurTarih> turTarihList = c.turTarihs.Where(x => x.tarih == date).ToList();

                List<Turlar> newlist = new();
                if (!string.IsNullOrEmpty(date))
                {

                    foreach (var item in turList)
                    {

                        foreach (var turTarih in turTarihList)
                        {
                            if (turTarih.turID == item.turID)
                            {
                                newlist.Add(item);
                            }
                        }
                    }
                }
                else
                {
                    newlist = turList;
                }
                List<bolge> bolges = new();
                bolges = c.bolges.ToList();
                ViewBag.bolge = bolges;
                List<Iletisim> iletisims = new();
                iletisims = c.iletisims.ToList();
                ViewBag.iletisim = iletisims;

                return View(newlist);

                
            }
            else {
                List<bolge> bolges = new();
                bolges = c.bolges.ToList();
                ViewBag.bolge = bolges;
                List<Iletisim> iletisims = new();
                iletisims = c.iletisims.ToList();
                ViewBag.iletisim = iletisims;
                var degerler = c.Turlars.ToList();
                return View(degerler);
            }

            
        }



       

        public IActionResult TurlarRu()
        {
            List<bolgeRU> bolgeList = c.bolgeRUs.ToList();
            List<Iletisim> iletisims = new();
            iletisims = c.iletisims.ToList();
            ViewBag.iletisim = iletisims;
            var degerler = c.TurlarRUs.ToList();
            List<bolgeRU> bolges = new();
            bolges = c.bolgeRUs.ToList();
            ViewBag.bolge = bolges;
            return View(degerler);

        }
        [HttpPost]
        public IActionResult TurlarRU(string search, string date, string adults)
        {
            if (!string.IsNullOrEmpty(search))
            {
           
                List<TurlarRU> turList = c.TurlarRUs.Where(x => x.bolgeRU.bolgeismi == search).ToList();
                List<TurTarihRU> turTarihList = c.turTarihRUs.Where(x => x.tarih == date).ToList();

                List<TurlarRU> newlist = new();
                if (!string.IsNullOrEmpty(date))
                {

                    foreach (var item in turList)
                    {

                        foreach (var turTarih in turTarihList)
                        {
                            if (turTarih.turID == item.turID)
                            {
                                newlist.Add(item);
                            }
                        }
                    }
                }
                else
                {
                    newlist = turList;
                }
                List<bolgeRU> bolges = new();
                bolges = c.bolgeRUs.ToList();
                ViewBag.bolge = bolges;
                List<Iletisim> iletisims = new();
                iletisims = c.iletisims.ToList();
                ViewBag.iletisim = iletisims;

                return View(newlist);


            }
            else
            {
                List<bolgeRU> bolges = new();
                bolges = c.bolgeRUs.ToList();
                ViewBag.bolge = bolges;
                List<Iletisim> iletisims = new();
                iletisims = c.iletisims.ToList();
                ViewBag.iletisim = iletisims;
                var degerler = c.TurlarRUs.ToList();
                return View(degerler);
            }


        }
        //Diller için ayrı
        public JsonResult tarih(string name)
        {
 
            var tarih =c.turTarihTRs.Where(x => x.TurlarTR.bolgeTR.bolgeismi == name).ToList();
            return Json(tarih); 
        }
        public JsonResult tarihEn(string name)
        {

            var tarih = c.turTarihs.Where(x => x.Turlar.Bolge.bolgeismi == name).ToList();
            return Json(tarih);
        }
        public JsonResult tarihRu(string name)
        {

            var tarih = c.turTarihRUs.Where(x => x.TurlarRU.bolgeRU.bolgeismi == name).ToList();
            return Json(tarih);
        }


    }
}
