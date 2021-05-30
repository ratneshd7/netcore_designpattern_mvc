using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactLib
{
    

   public  class ContactStore
    {
        List<Contact> contactList = new List<Contact>();
        public void AddContact(Contact contact)
        {
            contactList.Add(contact);
        }
       public List<Contact> GetContacts()
        {
            return contactList;
        }
    }
}
