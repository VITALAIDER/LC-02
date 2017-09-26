using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Web.Mvc;
using LC_02.Models;

namespace LC_02.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}