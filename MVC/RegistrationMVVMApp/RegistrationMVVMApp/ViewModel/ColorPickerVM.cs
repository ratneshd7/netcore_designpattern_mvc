using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistrationMVVMApp.ViewModel
{
    public class ColorPickerVM
    {
        public string ColorCode { get; set; }
        public string ColorName { get; set; }
        public string SelectedColor { get; set; }
        public List<SelectListItem> ColorLists = new List<SelectListItem>();

    }
}