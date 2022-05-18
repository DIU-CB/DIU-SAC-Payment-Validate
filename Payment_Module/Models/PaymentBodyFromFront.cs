using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment_Module.Models
{
    public class PaymentBodyFromFront
    {
        public string user_id { get; set; }
        public int amount { get; set; }
        public string currency_code { get; set; }
        public string cus_name { get; set; }
        public string cus_email { get; set; }
        public string cus_address { get; set; }
        public string cus_city { get; set; }
        public string cus_state { get; set; }
        public string cus_postcode { get; set; }
        public string cus_country { get; set; }
        public string cus_phone { get; set; }
        public string response_type { get; set; }
        public string success { get; set; }
        public string redirect { get; set; }
        public string reff_id { get; set; }
    }
}

