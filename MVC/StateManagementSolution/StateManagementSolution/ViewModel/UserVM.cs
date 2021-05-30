using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StateManagementSolution.ViewModel
{
    public class UserVM
    {
        [Required(ErrorMessage ="Username is required") ]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        public UserVM() { }
        public UserVM(string name,string pass)
        {
            Username = name;
            Password = pass;
        }

    }
}