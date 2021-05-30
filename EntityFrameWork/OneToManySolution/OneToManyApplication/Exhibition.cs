using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyApplication
{
    class Exhibition
    {
        public Guid ExhibitionId { get; set; }
        public string ExhibitionName { get; set; }
        public Organizer Organizer { get; set; }
        public Exhibition() {}
        public Exhibition(string EName,Guid id)
        {
            ExhibitionName = EName;
            ExhibitionId = id;
        }
    }
}
