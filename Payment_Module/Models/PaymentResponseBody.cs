using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment_Module.Models
{
    public class PaymentResponseBody
    {
        public PaymentResponse data { get; set; }
        public string message { get; set; }
    }
}
