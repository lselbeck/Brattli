using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Brattli2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Welcome to Brattli Consulting";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "What We Do";
            return View();
        }

        public ActionResult Performance()
        {
            ViewBag.Title = "Performance";
            return View();
        }

        public ActionResult Quotes()
        {
            ViewBag.Title = "Client Quotes";
            return View();
        }

        public ActionResult Loreen()
        {
            ViewBag.Title = "Loreen Brattli";
            return View();
        }

        public ActionResult Oystein()
        {
            ViewBag.Title = "Oystein Brattli";
            return View();
        }

        public ActionResult Principles()
        {
            ViewBag.Title = "Our Principles";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Title = "Contact";
            return View();
        }


    }
}