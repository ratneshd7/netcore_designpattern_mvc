using StateManagementSolution.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StateManagementSolution.Controllers
{
    public class CounterController : Controller
    {
        // GET: Counter
        CounterVM counter = new CounterVM();
        public ActionResult CounterView()
        {
            
            if (Session["Counts"] ==null)
            {
                Session["Counts"] = 0;
                IncrementCounterValue();           
                return View(counter);
            }
            IncrementCounterValue();
            return View(counter);
        }

        [HttpPost]
        public ActionResult CounterView(CounterVM ctr)
        {
            IncrementCounterValue();           
            return View(counter);
        }
        private void IncrementCounterValue()
        {
            var temp = int.Parse(Session["Counts"].ToString());
            counter.Old = temp;
            Session["Counts"] = ++temp;
            counter.New = int.Parse(Session["Counts"].ToString());
            counter.SessionID = Session.SessionID;
        }
    }
}