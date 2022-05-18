using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment_Module.Models
{
    public class PaymentDBContext:DbContext
    {
        public PaymentDBContext(DbContextOptions<PaymentDBContext> options):base(options)
        {


        }

        public DbSet<PaymentResponse> Application_Payment { get; set; }
    }
}
