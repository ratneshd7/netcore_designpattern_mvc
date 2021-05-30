using System;
using ContactLib;

namespace ContactConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact c = new Contact("Ratnesh","Dubey","9167137788","ratneshdubey194@gmail.com");
            ContactStore contactStore = new ContactStore();
            contactStore.AddContact(c);
            DisplayContacts(contactStore);
        }
        
        static void DisplayContacts(ContactStore contactStore)
        {
            foreach (Contact c in contactStore.GetContacts())
            {
                Console.WriteLine(c.FirstName);
            }
        }
    }
}
