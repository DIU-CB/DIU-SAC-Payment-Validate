using Microsoft.AspNetCore.Mvc;
using Payment_Module.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment_Module.Interface
{
    public interface IPayment
    {
        Task<PaymentResponseBody> PaymentVerification(string reffId);
    }
}
