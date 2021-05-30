using RepositoryDemoApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryDemoApp.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(int EmployeeID);
        void Insert(Employee employee);
        void Update(Employee employee);
        void Delete(int EmployeeID);
        void Save();
    }
}
