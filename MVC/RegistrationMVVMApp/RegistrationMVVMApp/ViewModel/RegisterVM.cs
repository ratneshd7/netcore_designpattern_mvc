using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationMVVMApp.ViewModel
{
    public class RegisterVM
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string Message { get; set; }
        public string MessageColor { get; set; }
    }
}