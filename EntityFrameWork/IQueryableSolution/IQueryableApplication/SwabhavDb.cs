using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQueryableApplication
{
    class SwabhavDb:DbContext
    {
        public DbSet<EMPIQUERYABLE> Employees { get; set; }
    }
}
