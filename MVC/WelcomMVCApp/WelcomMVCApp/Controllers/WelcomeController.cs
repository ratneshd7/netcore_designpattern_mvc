using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WelcomMVCApp.Controllers
{
    public class WelcomeController:Controller
    {
        public String Index()
        {
            return "<h1>Welcome To MVC</h1>";
        }
        public String Message( String user)
        {
            if (user != null)
            {
                return "<h1>Hello "+user+" </h1>";
            }
            else
                return "<h1>Hello Swabhav</h1>";
        }
        public ActionResult Browse()
        {
            ViewBag.msgFromController = "Message BY using ViewBag";
            ViewData["msgFromViewData"] = "Message BY using ViewData";
            TempData["msgTempdata"] = "Message BY using TempData";
            return this.View();
        }

        
    }
}