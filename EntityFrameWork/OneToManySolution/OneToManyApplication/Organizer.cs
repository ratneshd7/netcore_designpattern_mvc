using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyApplication
{
    class Organizer
    {
        public Guid OrganizerId { get; set; }
        public string OrganizerName { get; set; }
        public List<Exhibition> Exhibitions { get; set; }
    }
}
