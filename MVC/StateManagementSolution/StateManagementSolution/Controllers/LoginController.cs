using StateManagementSolution.Services;
using StateManagementSolution.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StateManagementSolution.Controllers
{
    public class LoginController : Controller
    {
        UserVM uservm = new UserVM();
        AuthenticationService auth = new AuthenticationService();
        // GET: Login
        public ActionResult Index()
        {
            return View("LoginView",uservm);
        }
        [HttpPost]
        public ActionResult Index(UserVM user)
        {
            if (ModelState.IsValid)
            {
                Session["User"] = auth.AuthenticateUser(user.Username, user.Password);
                if (Session["User"] != null)
                {

                    return RedirectToAction("Index", "Welcome/WelcomeView");
                }
            }
            return View("LoginView", user);
        }
    }
}