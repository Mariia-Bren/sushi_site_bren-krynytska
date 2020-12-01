using sushi_site_work.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
        public ActionResult Browse(string subCategory)
        {
            // Retrieve Genre and its Associated Albums from database
            var subCategoryModel = db.subCategories.Single(s => s.Name == subCategory);

            return View(subCategoryModel);
        }
        //
        // GET: /Store/Details
        public ActionResult Details(int id)
        {
            var product = db.products.Find(id);

            return View(product);
        }

        //
        // GET: /Store/GenreMenu
        [ChildActionOnly]
        public ActionResult SubCategoriesMenu()
        {
            var subCategories = db.subCategories.ToList();
            return PartialView(subCategories);
        }
    }
}