using sushi_site_work.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;


namespace sushi_site_work.Controllers
{
    public class StoreController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        //
        // GET: /Store/
        public ActionResult Index()
        {
            var subCategory = db.subCategories.ToList();
            return View(subCategory);
        }
        //
        // GET: /Store/Browse
        public ActionResult Browse(string subCategories)
        {
            // Retrieve Genre and its Associated Albums from database
            var subCategoriesModel = db.subCategories.Include("Products").Single(g => g.Name == subCategories);

            return View(subCategoriesModel);
        }

        // GET: /Store/Details
        public ActionResult Details(int id)
        {
            var product = db.products.Find(id);

            return View(product);
        }

        //
        // GET: /Store/SubCategoriesMenu
        [ChildActionOnly]
        public ActionResult SubCategoriesMenu()
        {
            var subCategories = db.subCategories.ToList();
            return PartialView(subCategories);
        }
       
    }
}