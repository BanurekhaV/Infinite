using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day3EFPrj.Models;

namespace Day3EFPrj.Controllers
{
    public class CategoryController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Category
        //returning the scaffolded view of the categories
        public ActionResult Index()
        {
            return RedirectToAction("GetCategoryScaffolded");          
        }

        //eg 1. Fetch Data from Category table
        public ActionResult GetCategoryDetails()
        {
            List<Category> category = db.Categories.ToList();
            return View(category);
        }

        // 2. fetch data from category table and use a scaffolded view to display data
        public ActionResult GetCategoryScaffolded()
        {
            List<Category> cat = db.Categories.ToList();
            return View(cat);
        }

        //eg 3. Using Query Syntax to get category names sorted
        public ActionResult GetCat_ByName()
        {
            List<string> catname = (from c in db.Categories
                                    orderby c.CategoryName
                                    select c.CategoryName).ToList();
            return View(catname);
        }

        //eg 4. Using method syntax to get category names sorted

        public ActionResult GetCat_ByMethod()
        {
            IEnumerable<string> catname = (db.Categories.OrderBy(c => c.CategoryName).Select(
                c1 => c1.CategoryName)).ToList();
            return View(catname);
        }
        
    }
}