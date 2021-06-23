using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeDeptMVC.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public decimal Salary { get; set; }
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
    }
}
