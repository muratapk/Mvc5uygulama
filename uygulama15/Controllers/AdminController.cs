using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using uygulama15.Models;

namespace uygulama15.Controllers
{
    public class AdminController : Controller
    {
        uygulamaEntities baglan=new uygulamaEntities();

        // GET: Admin
        public ActionResult Index()
        {
            var liste = baglan.admin.ToList();
            return View(liste);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
    }
}