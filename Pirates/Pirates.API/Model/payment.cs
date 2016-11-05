using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pirates.API.Model
{
    public class Payment
    {
        public string CardType { get; set; }

        public string NameOnCard { get; set; }
        public string CardNumber { get; set; }
        public string ExpiryDate { get; set; }
        public string CCV { get; set; }

    }
}