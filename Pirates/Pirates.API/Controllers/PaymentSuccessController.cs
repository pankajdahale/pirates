using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Pirates.API.Model;

namespace Pirates.API.Controllers
{
    public class PaymentSuccessController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Index()
        {
            return Ok(new List<PaymentSuccess>()
            {
                 new PaymentSuccess { ConfirmtionNumber = "100", PaymentDate = "16/10/2016", AmountPaid = "100" },


            });

        }


        [HttpPost]
        public IHttpActionResult Detail(PaymentSuccess vm)
        {
            return Ok();

        }
    }
}