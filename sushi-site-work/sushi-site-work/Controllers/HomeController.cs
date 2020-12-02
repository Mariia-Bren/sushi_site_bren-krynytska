using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sushi_site_work.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "На сторінці опису вашої програми.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Ваша контактна сторінка.";

            return View();
        }
    }
}