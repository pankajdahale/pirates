using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Data;

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
                
            });

        }

        [HttpPost]
        public IHttpActionResult Detail(DetailVM vm)
        {
            return Ok();
        }

    }

    public class DetailVM
    {
        public string Name { get; set; }
        public string VehicleNumber { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public string TicketNumber { get; set; }
        public string PolicePersonName { get; set; }
        public int StateId { get; set; }
    }
}
