using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YildirimlarE.Models;
namespace YildirimlarE.Controllers
{
    public class MainMenuController : Controller
    {
        Context db = new Context();
        BirlesikTablolar bt = new BirlesikTablolar();
        // GET: MainMenu
        public ActionResult Index()
        {
            var dgr = db.Abouts.ToList();
            return View(dgr);
        }
        public PartialViewResult Partial1()
        {
            var dgr = db.Magzas.OrderByDescending(x=>x.MagzaId).ToList();
            return PartialView(dgr);
        }
        public PartialViewResult Partial2()
        {
            var dgr = db.Uruns.Take(3).OrderByDescending(x=>x.UrunId).ToList();
            return PartialView(dgr);
        }
        public PartialViewResult Partial4()
        {
            var dgr = db.Uruns.Take(10).ToList();
            return PartialView(dgr);
        }
        public PartialViewResult Partial5()
        {
            bt.u= db.Uruns.Take(3).ToList();
            bt.u2= db.Uruns.OrderByDescending(x=>x.UrunId).Take(3).ToList();
            return PartialView(bt);
        }
    }
}