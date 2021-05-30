using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StateManagementSolution.Models
{
    public class Task
    {
        public string TaskName { get; set; }
        [Required(ErrorMessage = "Please enter Task.")]
        public string InputTaskName { get; set; }
        public Task(string taskName)
        {
            TaskName = taskName;
        }
        public Task(){}
        public List<Task> Tasklists = new List<Task>();

    }
}