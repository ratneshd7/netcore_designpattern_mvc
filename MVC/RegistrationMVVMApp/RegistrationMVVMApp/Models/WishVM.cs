using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistrationMVVMApp.Models
{
    public class WishVM
    {
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter name")]
        [ MinLength(5, ErrorMessage = "Please enter name which has more than 5 character")]
        public string Name { get; set; }
        public string WishMessage { get; set; }
        
    }
}