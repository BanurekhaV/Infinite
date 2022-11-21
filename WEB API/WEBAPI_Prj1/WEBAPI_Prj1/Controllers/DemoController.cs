using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEBAPI_Prj1.Models;

namespace WEBAPI_Prj1.Controllers
{
    public class DemoController : ApiController
    {
        static List<string> continents = new List<string> { "Asia", "Africa", "Antartica", "Europe", "America" };
        
        //Get : api/Demo
        public IEnumerable<string> Get()
        {
            return continents;
        }

        //Get : api/Demo/2

        public string Get(int id)
        {
            return continents[id];
        }

        //Post 
        public IEnumerable<string> Post([FromBody] Sample s)
        {
            continents.Add(s.name);
            //continents.Add(val);
            return continents;
        }
        [HttpPost]
        public IEnumerable<string>Addstring([FromUri] string val)
        {
            continents.Add(val);
            return continents;
        }
    }
}
