using RegistrationMVVMApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistrationMVVMApp.Controllers
{
    public class TaskController : Controller
    {
        TaskVM taskVM = new TaskVM();
        // GET: Task
        public ActionResult TaskView()
        {
            return View("TaskView", new TaskVM());
        }
        [HttpPost]
        public ActionResult TaskView(TaskVM taskvm)
        {
            taskvm.TaskList.Add(taskvm.Task);
            taskvm.Task = "";
            return View("TaskView", taskvm);
        }
    }
}