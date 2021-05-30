using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitOfWorkRepositoryPattern.DAL;
using UnitOfWorkRepositoryPattern.Repository;
using UnitOfWorkRepositoryPattern.UnitOfWorks;

namespace  UnitOfWorkRepositoryPattern.Controllers
{
    public class EmployeeController : Controller
    {
        private IGenericRepository<Employee> _employeeRepository;
        private IUnitOfWork _unitOfWork = null;
        public EmployeeController(EmployeeDBContext contexxt)
        {
            this._unitOfWork = new UnitOfWork(contexxt);
            GenericRepository<Employee> e = new GenericRepository<Employee>(this._unitOfWork);

            this._employeeRepository = e;
        }
        [HttpGet]
        public ActionResult Index()
        {
            var model = _employeeRepository.GetAll();
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
                _employeeRepository.Insert(model);
                _employeeRepository.Save();
                return RedirectToAction("Index", "Employee");
            }
            return View();
        }
        [HttpGet]
        public ActionResult EditEmployee(int EmployeeId)
        {
            Employee model = _employeeRepository.GetById(EmployeeId);
            return View(model);
        }
        [HttpPost]
        public ActionResult EditEmployee(Employee model)
        {
            if (ModelState.IsValid)
            {
                _employeeRepository.Update(model);
                _employeeRepository.Save();
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
            Employee model = _employeeRepository.GetById(EmployeeId);
            return View(model);
        }
        
    }
}
