using RegistrationMVVMApp.Services;
using RegistrationMVVMApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistrationMVVMApp.Controllers
{
    public class ColorPickerController : Controller
    {
        // GET: ColorPicker
        ColorService colorService = new ColorService();
        public ActionResult Index()
        {
            ColorPickerVM colorPicker = new ColorPickerVM();

            colorPicker.ColorLists = ConvertData(colorService.getColorList());
            colorPicker.ColorCode = "";
            colorPicker.ColorName = "";
            return View("ColorPickerView",colorPicker);
        }
        [HttpPost]
        public ActionResult Index(ColorPickerVM colorPicker)
        {
            
            colorPicker.ColorLists = ConvertData(colorService.getColorList());
            for (int i=0;i< colorPicker.ColorLists.Count();i++)
            {
                if (colorPicker.ColorLists[i].Value==colorPicker.SelectedColor)
                {
                    colorPicker.ColorName = colorPicker.ColorLists[i].Text;
                }
                
            }
            
            colorPicker.ColorCode = colorPicker.SelectedColor;
            return View("ColorPickerView", colorPicker);
            
        }
        public List<SelectListItem> ConvertData(List<Models.Color> list)
        {

            return list.Select(x => new SelectListItem() { Text = x.ColorText, Value = x.ColorValue }).ToList();
        }
    }
}