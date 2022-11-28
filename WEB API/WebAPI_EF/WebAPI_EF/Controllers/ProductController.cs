using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_EF.Models;

namespace WebAPI_EF.Controllers
{
    public class ProductController : ApiController
    {
        InfiniteDBEntities db = new InfiniteDBEntities();
        //Get
        public IEnumerable<Product>Get()
        {
            return db.Products.ToList();
        }

        //Post
        public IHttpActionResult PostNewProduct([FromBody]Product p)
        {
            if (!ModelState.IsValid)
                return BadRequest("Validations Failed");
            db.Products.Add(new Product()
            {
                ProductId=p.ProductId,
                ProdName=p.ProdName,
                Price=p.Price,
                QtyAvailable=p.QtyAvailable,
            });
            db.SaveChanges();
            return Ok("Success");
        }
    }
}
