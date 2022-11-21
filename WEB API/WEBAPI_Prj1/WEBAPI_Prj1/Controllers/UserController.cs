using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEBAPI_Prj1.Models;

namespace WEBAPI_Prj1.Controllers
{
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {
        static List<Users> userlist = new List<Users>()
        {
            new Users{ID=1,Name="Rohan", Role="Operations"},
            new Users{ID=2,Name="Vikram", Role="Admin"},
            new Users{ID=3,Name="Rahul", Role="User"},
        };

        [HttpGet]
        [Route("General")]
        public IEnumerable<Users>Get()
        {
            return userlist;
        }

        //Get using HttpResponseMessage object
        [HttpGet]
        [Route("UserHttp")]
        public HttpResponseMessage GetUserList()
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, userlist);
            return response;
        }


    }
}
