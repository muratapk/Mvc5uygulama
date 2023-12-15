using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace uygulama15.Controllers
{
    public class SayfalarController : Controller
    {
        // GET: Sayfalar
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Mustafa()
        {
            ViewBag.Mesaj = "Merhaba";
            TempData["Konu"] = "İyi Akşamlar";
            ViewData["Konu2"] = "İyi Geceler";
            return View();
        }
    }
}