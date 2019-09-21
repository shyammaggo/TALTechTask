using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TALPremiumCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetOccupationListController : System.Web.Http.ApiController
    {

        // GET api/<controller>

        //var collection = new Dictionary<string, object>();
        //collection.Add("1.50", "Cleaner");
        //collection.Add("1.0", "Doctor");
        //collection.Add("1.25", "Author");
        //collection.Add("1.75", "Farmer");
        //collection.Add("1.75", "Mechanic");
        //collection.Add("1.50", "Florist");
        //return Request.CreateResponse(HttpStatusCode.OK, collection, "application/json");
        [HttpGet("[action]")]
        public IDictionary<string,string> GetOccupation()
        {
            // return new string[] { "value1", "value2" };
            var getOccupations = new Dictionary<string, string>();
            getOccupations.Add("1.50", "Cleaner");
            getOccupations.Add("1.0", "Doctor");
            getOccupations.Add("1.25", "Author");
            getOccupations.Add("1.75", "Farmer");
            getOccupations.Add("1.80", "Mechanic");//1.75
            getOccupations.Add("1.60", "Florist");//1.50

            return getOccupations;
        }


        
    }
}
