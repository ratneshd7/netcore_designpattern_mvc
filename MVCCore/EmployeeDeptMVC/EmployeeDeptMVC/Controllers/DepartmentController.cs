using EmployeeDeptMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDeptMVC.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            EmployeeMVCDBContext employeeMVCDBContext = new EmployeeMVCDBContext();
            List<Department> deptlist = employeeMVCDBContext.Departments.ToList();
            return View(deptlist);
        }
    }
}
