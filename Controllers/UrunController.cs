using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YildirimlarE.Models;
namespace YildirimlarE.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        Context db = new Context();
        BirlesikTablolar bt = new BirlesikTablolar();
        public ActionResult Index(int id)
        {
            if (id == 0)
            {
                bt.u = db.Uruns.ToList();
            }
            else
            {
                bt.u = db.Uruns.Where(x => x.kategori.Id == id).ToList();
            }
            bt.u2 = db.Uruns.Take(3).ToList();
            bt.u3 = db.Uruns.Take(3).OrderByDescending(x=>x.UrunId).ToList();
            return View(bt);
        }
        public ActionResult UrunDetay(int id)
        {
            bt.u = db.Uruns.Where(x => x.UrunId == id).ToList();
            bt.m2 = db.Magzas.Take(3).OrderByDescending(x => x.MagzaId).ToList();
            bt.u2 = db.Uruns.Take(7).OrderByDescending(x => x.UrunId).ToList();
            bt.uy = db.UrunYorums.Where(x=>x.Urun.UrunId==id).OrderByDescending(x => x.Id).ToList();
            return View(bt);
        }
        [HttpGet]
        public PartialViewResult YorumYapP(int id)
        {
            ViewBag.dgr = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult YorumYapP(UrunYorum u)
        {
            db.UrunYorums.Add(u);
            db.SaveChanges();
            return PartialView();
        }
    }
}