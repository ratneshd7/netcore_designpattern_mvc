using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCustomerApplication
{
    class Customer
    {
        [Key]
        public int Id  { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        public string Designation { get; set; }
        public Customer() { }
        public Customer(int id,string fname,string lname,string location,string designation)
        {
            Id = id;
            FirstName = fname;
            LastName = lname;
            Location = location;
            Designation = designation;
        }
    }
}
 