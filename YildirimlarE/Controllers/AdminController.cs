using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YildirimlarE.Models;
namespace YildirimlarE.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        Context db = new Context();
        // GET: Index
        public ActionResult Index()
        {
            var dgr = db.Uruns.ToList();
            return View(dgr);
        }
        public ActionResult UrunSil(int id)
        {


            Console.WriteLine("Hello World");


            var dgr = db.Uruns.Find(id);
            db.Uruns.Remove(dgr);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UrunEkle()
        {
            List<SelectListItem> degerler = (from i in db.Kategoris.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.KategoriAd,
                                                 Value = i.Id.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }
        [HttpPost]
        public ActionResult UrunEkle(Urun u)
        {
            var ktg = db.Kategoris.Where(m => m.Id == u.kategori.Id).FirstOrDefault();
            u.kategori = ktg;
            db.Uruns.Add(u);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UrunGetir(int id)
        {
            List<SelectListItem> degerler = (from i in db.Kategoris.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.KategoriAd,
                                                 Value = i.Id.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            ViewBag.dgr2 = id;


            var urn = db.Uruns.Find(id);
            return View("UrunGetir", urn);
        }
        public ActionResult UrunGuncelle(Urun p1)
        {

            var urun = db.Uruns.Find(p1.UrunId);
            urun.Ad = p1.Ad;

            ////urun.UrunKategori = urun.UrunKategori;
            //var ktg = db.Kategoris.Where(m => m.Id == p1.kategori.Id).FirstOrDefault();    //40.ders biraz karıştı gibi sanki
            //urun.kategori.Id = ktg.Id;
            urun.FotoUrl = p1.FotoUrl;
            urun.UrunAciklama = p1.UrunAciklama;
            urun.Stok = p1.Stok;
            db.SaveChanges();
            return RedirectToAction("Index");
        }



        public ActionResult Magzalar()
        {
            var dgr = db.Magzas.ToList();
            return View(dgr);
        }
        public ActionResult MagzaSil(int id)
        {
            var dgr = db.Magzas.Find(id);
            db.Magzas.Remove(dgr);
            db.SaveChanges();
            return RedirectToAction("Magzalar");
        }

        [HttpGet]
        public ActionResult MagzaEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MagzaEkle(Magza u)
        {
            db.Magzas.Add(u);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult MagzaYorumlari(Magza u)
        {
            var dgr = db.MagzaYorums.ToList();
            return View(dgr);
        }
        public ActionResult Urunyorumlari(Magza u)
        {
            var dgr = db.UrunYorums.ToList();
            return View(dgr);
        }
        public ActionResult UrunYorumSil(int id)
        {
            var dgr = db.UrunYorums.Find(id);
            db.UrunYorums.Remove(dgr);
            db.SaveChanges();
            return RedirectToAction("UrunYorumlari");
        }
        public ActionResult MagzaYorumSil(int id)
        {
            var dgr = db.MagzaYorums.Find(id);
            db.MagzaYorums.Remove(dgr);
            db.SaveChanges();
            return RedirectToAction("MagzaYorumlari");
        }

    }
}



