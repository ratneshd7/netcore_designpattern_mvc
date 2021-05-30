using StateManagementSolution.Models;
using StateManagementSolution.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StateManagementSolution.Controllers
{
    public class TaskGlobalController : Controller
    {
        TaskGlobalService taskGlobservice = new TaskGlobalService();
        Task t = new Task();
        // GET: TaskGlobal
        public ActionResult Index()
        {
            if (Session["tasklistkey"] == null)
            {
                Session["tasklistkey"] = taskGlobservice;
                GetTaskListFromSeession();
                return View("TaskGlobalView", t);
            }
            GetTaskListFromSeession();
            return View("TaskGlobalView",t);
        }

        [HttpPost]
        public ActionResult Index(Task task)
        {
            TaskGlobalService taskSessionObj = (TaskGlobalService)Session["tasklistkey"];
            taskSessionObj.AddTask(task.InputTaskName);
            GetTaskListFromSeession();
            return View("TaskGlobalView", t);
        }
        private void GetTaskListFromSeession()
        {
            
            taskGlobservice = (TaskGlobalService)Session["tasklistkey"];
            t.Tasklists = taskGlobservice.GetTaskList();
        }
    }
}