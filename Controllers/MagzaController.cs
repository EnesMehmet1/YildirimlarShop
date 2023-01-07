using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YildirimlarE.Models;
namespace YildirimlarE.Controllers
{
    public class MagzaController : Controller
    {
        Context db = new Context();
        BirlesikTablolar bt = new BirlesikTablolar();
        // GET: Magza
        public ActionResult Index()
        {
            bt.m = db.Magzas.ToList();
            bt.u = db.Uruns.Take(7).OrderByDescending(x=>x.UrunId).ToList();
            return View(bt);
        }
        public ActionResult MagzaDetay(int id)
        {
            var dgr = db.Magzas.Where(x => x.MagzaId == id).ToList();
            bt.m= db.Magzas.Where(x => x.MagzaId == id).ToList();
            bt.y=db.MagzaYorums.Where(x => x.Magza.MagzaId == id).ToList();
            bt.m2= db.Magzas.Take(3).OrderByDescending(x=>x.MagzaId).ToList();
            bt.u= db.Uruns.Take(7).OrderByDescending(x=>x.UrunId).ToList();
            return View(bt);
        }


        [HttpGet]
        public ActionResult YorumYapP(int id)
        {
            ViewBag.dgr = id;
            return PartialView();
        }
        [HttpPost]
        public ActionResult YorumYapP(MagzaYorum y)
        {
            db.MagzaYorums.Add(y);
            db.SaveChanges();
            return PartialView();
        }
    }
}