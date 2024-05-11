using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;
using ClientApp.Services;

namespace ClientApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Encender()
        {
            WS ws = new WS();
            string text = ws.Encender();
            ViewBag.Message = text;

            return View();
        }

        public ActionResult Apagar()
        {
            WS ws = new WS();
            string text = ws.Apagar();
            ViewBag.Message = text;

            return View();
        }
    }
}