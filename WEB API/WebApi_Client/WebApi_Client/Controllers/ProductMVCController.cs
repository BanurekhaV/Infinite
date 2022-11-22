using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApi_Client.Models;
using System.Net.Http;
using Newtonsoft.Json;


namespace WebApi_Client.Controllers
{
    public class ProductMVCController : Controller
    {
        // GET: ProductMVC
        public ActionResult Index()
        {
            return View();
        }

        //action method that is to consume the web api get
       // [AllowAnonymous]
        public ActionResult Display()
        {
            IEnumerable<MVCProductModel> prodlist = null;
            using(var webclient=new HttpClient())
            {
                webclient.BaseAddress = new Uri("https://localhost:44387/api/");
                var responsetask = webclient.GetAsync("product");
                responsetask.Wait();
                var result = responsetask.Result;
                if(result.IsSuccessStatusCode)
                {
                    var resultdata = result.Content.ReadAsStringAsync().Result;
                    prodlist = JsonConvert.DeserializeObject<List<MVCProductModel>>(resultdata);
                }
                else
                {
                    prodlist = Enumerable.Empty<MVCProductModel>();
                    ModelState.AddModelError(string.Empty, "Some Error Occured.. Try Later");
                }
                return View(prodlist);
            }
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
       // [Authorize]
        public ActionResult Create(MVCProductModel prod)
        {
            using (var webclient = new HttpClient())
            {
                webclient.BaseAddress = new Uri("https://localhost:44387/api/");
                var posttask = webclient.PostAsJsonAsync<MVCProductModel>("product", prod);
                posttask.Wait();
                var dataresult = posttask.Result;
                if(dataresult.IsSuccessStatusCode)
                {
                    return RedirectToAction("Display");
                }
            }
            ModelState.AddModelError(string.Empty, "Some Error Occured..");
            return View(prod);
        }

    }
}