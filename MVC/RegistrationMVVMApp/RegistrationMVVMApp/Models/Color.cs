using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationMVVMApp.Models
{
    public class Color
    {
        public string ColorValue { get; set; }
        public string ColorText { get; set; }
        public Color(string colorText, string colorValue)
        {
            this.ColorValue = colorValue;
            this.ColorText = colorText;
        }
    }
}