using RegistrationMVVMApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistrationMVVMApp.Controllers
{
    public class RegistrationVMController:Controller
    {
        public ActionResult Index()
        {
            RegisterVM regVM = new RegisterVM();
            regVM.Email = "";
            regVM.MobileNo = "";
            regVM.Name = "";
            regVM.Message = "";
            regVM.MessageColor = "";
            return View("RegisterView",regVM);
        }
        [HttpPost]
        public ActionResult Index(RegisterVM regVM)
        {
            if (regVM.Name==null || regVM.Email==null || regVM.MobileNo==null )
            {
                regVM.Message = "pls fill all field";
                regVM.MessageColor = "red";
                return View("RegisterView", regVM);
            }
            else
            {
                regVM.Message = "Form Submitted Successfully";
                regVM.MessageColor = "green";
                return View("RegisterView", regVM);
            }
           
        }
    }
}