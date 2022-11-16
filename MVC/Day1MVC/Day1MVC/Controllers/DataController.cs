using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day1MVC.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        public ActionResult Index()
        {
            return View();
        }

        //eg 1. to work with viewbag and viewdata
        public ActionResult OfficeRules()
        {
            List<string> rule = new List<string>()
            {"Avoid T-Shirt","Carry your ID card","Be On Time",
                "Complete Work as per the deadlines"
                            };
            //let us transfer the data to a viewbag object
            ViewBag.OffRules = rule;
           // return View();

            ViewData["FollowRules"] = rule;
            return View();
        }

        //eg :2 to check if viewbag/viewdata values be sent to other request
        public ActionResult TestData()
        {
            ViewBag.data1 = "Data one";
            ViewData["data2"] = "Data two";
             return View(); //view is able to show the viewbag/viewdatas data
            // in both the below cases, we are not able to transfer the 
            //viewbag/viewdata objects values to other views
            //  return Redirect("Index"); //redirection to an action method of the same controller
            //return RedirectToAction("Index", "Demo"); //redirection to an action method of another controller
        }
    }
}