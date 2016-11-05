using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Data;
using Pirates.API.Model;

namespace Pirates.API.Controllers
{
    public class StateController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Index()
        {
            return Ok(new List<State>()
            {
                new State {Name = "M", StateId = 1},
                new State {Name = "G", StateId = 2},
                new State {Name = "H", StateId = 2},
                
            });

        }

        [HttpPost]
        public IHttpActionResult Detail(DetailVM vm)
        {
            return Ok();
        }

    }
}
