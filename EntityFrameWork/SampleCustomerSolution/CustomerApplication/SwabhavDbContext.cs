using SimpleCustomerApplication;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApplication
{
    class SwabhavDbContext : DbContext
    {
        public SwabhavDbContext() : base("SwabhavDatabase")
        {

        }
        public DbSet<Customer> Customers { get; set; }
    }
}
