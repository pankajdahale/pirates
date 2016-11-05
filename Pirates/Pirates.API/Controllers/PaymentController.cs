using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using Pirates.API.Model;

namespace Pirates.API.Controllers
{
    public class PaymentController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Index()
        {
            return Ok(new List<Payment>()
            {
               


            });

        }


        [HttpPost]
        public IHttpActionResult Detail(Payment vm)
        {
            return Ok("Index");

        }





    }
}