using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyApplication
{
    class SwabhavDbContext:DbContext
    {
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Exhibition> Exhibitions { get; set; }
    }
}
