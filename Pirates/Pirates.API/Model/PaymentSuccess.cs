using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pirates.API.Model
{
    public class PaymentSuccess
    {
        public string ConfirmtionNumber { get; set; }
        public string PaymentDate { get; set; }
        public string AmountPaid { get; set; }
    }
}