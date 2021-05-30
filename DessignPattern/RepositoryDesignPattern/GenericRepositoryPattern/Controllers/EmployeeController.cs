using GenericRepositoryPattern.DAL;
using GenericRepositoryPattern.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitOfWorkRepositoryPattern.UnitOfWorks;

namespace GenericRepositoryPattern.Controllers
{
    public class EmployeeController : Controller
    {
        private IGenericRepository<Employee> repository = null;
        public EmployeeController(EmployeeDBContext context)
        {
            UnitOfWork unitOfWork = new UnitOfWork(context);
            GenericRepository<Employee> e = new GenericRepository<Employee>(context);

            this.repository = e;
        }
        [HttpGet]
        public ActionResult Index()
        {
            var model = repository.GetAll();
            for (int i = 0; i < 200; i++)
            {
                var temp = repository.GetAll();
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(Employee model)
        {
            if (ModelState.IsValid)
            {
                repository.Insert(model);
                repository.Save();
                return RedirectToAction("Index", "Employee");
            }
            return View();
        }
        [HttpGet]
        public ActionResult EditEmployee(int EmployeeId)
        {
            Employee model = repository.GetById(EmployeeId);
            return View(model);
        }
        [HttpPost]
        public ActionResult EditEmployee(Employee model)
        {
            if (ModelState.IsValid)
            {
                repository.Update(model);
                repository.Save();
                return RedirectToAction("Index", "Employee");
            }
            else
            {
                return View(model);
            }
        }
        [HttpGet]
        public ActionResult DeleteEmployee(int EmployeeId)
        {
            Employee model = repository.GetById(EmployeeId);
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int EmployeeID)
        {
            repository.Delete(EmployeeID);
            repository.Save();
            return RedirectToAction("Index", "Employee");
        }
    }
}
