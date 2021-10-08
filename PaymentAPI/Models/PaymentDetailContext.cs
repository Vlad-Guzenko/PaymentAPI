using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Models
{
    public class PaymentDetailContext : DbContext
    {
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
        public PaymentDetailContext(DbContextOptions<PaymentDetailContext> options) : base(options) { }
    }
}
