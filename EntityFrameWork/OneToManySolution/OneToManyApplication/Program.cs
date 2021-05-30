using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Organizer org = new Organizer();
            SwabhavDbContext db = new SwabhavDbContext();
            org.OrganizerName = "GSMKTG";
            org.OrganizerId = Guid.NewGuid();
            org.Exhibitions = new List<Exhibition>();
            org.Exhibitions.Add(new Exhibition("IIMTF",Guid.NewGuid()));
            org.Exhibitions.Add(new Exhibition("IICF", Guid.NewGuid()));
            db.Organizers.Add(org);
            db.SaveChanges();
        }
    }
}
