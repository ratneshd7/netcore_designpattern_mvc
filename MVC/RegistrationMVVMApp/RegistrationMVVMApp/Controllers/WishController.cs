using RegistrationMVVMApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistrationMVVMApp.Controllers
{
    public class WishController : Controller
    {
        // GET: Wish
        public ActionResult Index()
        {
            WishVM wishvm = new WishVM();
            //wishvm.Name = "";
            return View("WishView",wishvm);
        }
        [HttpPost]
        public ActionResult Index(WishVM wishvm)
        {
            if (ModelState.IsValid)
            {
                wishvm.WishMessage = "Hello Mr. " + wishvm.Name;
                return View("WishView", wishvm);
            }
            
            return View("WishView",wishvm);
        }
    }
}