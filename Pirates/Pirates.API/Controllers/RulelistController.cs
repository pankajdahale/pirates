using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;

using Data;
using Pirates.API.Model;

namespace Pirates.API.Controllers
{
    public class RulelistController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Index()
        {
            return Ok(new List<RuleDetails>()
            {
                new RuleDetails { Id = 1, ListOfRules = "Driving without license", Pay = "100" },
                new RuleDetails { Id = 2, ListOfRules = "Driving without carrying proper documents", Pay = "200" },
                new RuleDetails { Id = 3, ListOfRules = "Driving without carrying Insurance paper", Pay = "150" },
                new RuleDetails { Id = 4, ListOfRules = "Driving without Helmet", Pay = "100" },
            });

        }


        [HttpPost]
        public IHttpActionResult Detail(RuleDetails vm)
        {
            return Ok();
        }
    }
}