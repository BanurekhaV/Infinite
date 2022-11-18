using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day3EFPrj.Models;

namespace Day3EFPrj.Controllers
{
    public class ShippersController : Controller
    {
        NorthwindEntities ne = new NorthwindEntities();
        // GET: Shippers
        public ActionResult Index()
        {
            return View(ne.Shippers.ToList());
        }

        [HttpGet]
        public ActionResult CreateShipper()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateShipper(Shipper s)
        {
            ne.Shippers.Add(s);
            ne.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}