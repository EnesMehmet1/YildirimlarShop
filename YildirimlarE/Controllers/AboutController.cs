using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YildirimlarE.Models;
namespace YildirimlarE.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context db = new Context();
        public ActionResult Index()
        {
            var dgr = db.Abouts.ToList();
            return View(dgr);
        }
    }
}