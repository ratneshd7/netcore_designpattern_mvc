using EmployeeDeptMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDeptMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index(int departmentId)
        {
            EmployeeMVCDBContext employeeMVCDBContext = new EmployeeMVCDBContext();
            List<Employee> emplist = employeeMVCDBContext.Employees.Where(emp => emp.DepartmentId==departmentId).ToList();
            return View(emplist);
        }
    }
}
