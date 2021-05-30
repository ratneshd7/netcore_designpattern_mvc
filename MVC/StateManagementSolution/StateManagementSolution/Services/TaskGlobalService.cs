using StateManagementSolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StateManagementSolution.Services
{
    public class TaskGlobalService
    {
        public  List<Task> Tasklist = new List<Task>();

        public  void AddTask(string taskname)
        {
            if(taskname != null)
            Tasklist.Add(new Task(taskname));
        }
       public  List<Task> GetTaskList()
        {
            return Tasklist;
        }
    }
}