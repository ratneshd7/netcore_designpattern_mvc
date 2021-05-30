using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationMVVMApp.Services
{
    public class ColorService
    {
        
        public List<Models.Color> AllowedColor = new List<Models.Color>();

        public List<Models.Color> getColorList()
        {

            AllowedColor.Add(new Models.Color("RED", "#f23a56"));
            AllowedColor.Add(new Models.Color("BLUE", "#458af7"));
            AllowedColor.Add(new Models.Color("GREEN", "#51cc1d"));
            return AllowedColor;
        }
    }
}