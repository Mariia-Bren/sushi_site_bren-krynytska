using sushi_site_work.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace sushi_site_work.Controllers
{
    public class HomeController : Controller
    {

        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            // Get most popular albums
            var albums = GetTopSellingProducts(3);

            return View(albums);
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
        private List<Product> GetTopSellingProducts(int count)
        {
           return db.products
                .OrderByDescending(a => a.OrderDetails.Count())
                .Take(count)
                .ToList();
        }

    }
}