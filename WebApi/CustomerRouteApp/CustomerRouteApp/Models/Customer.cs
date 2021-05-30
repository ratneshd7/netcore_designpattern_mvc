using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerRouteApp.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        public Customer() { }
        public Customer(Guid id,string fname,string lname,string location)
        {
            Id = id;
            FirstName = fname;
            LastName = lname;
            Location = location;
        }
    }
}