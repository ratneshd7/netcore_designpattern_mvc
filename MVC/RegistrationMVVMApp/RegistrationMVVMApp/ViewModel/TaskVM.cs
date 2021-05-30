using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistrationMVVMApp.ViewModel
{
    public class TaskVM
    {
        [Required(ErrorMessage = "Please enter Task")]
        public string Task { get; set; }
        public List<string> TaskList = new List<string>();
    }
}