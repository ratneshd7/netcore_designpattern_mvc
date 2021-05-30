using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepositoryPattern.DAL
{
    [Table("Employee")]
    public partial class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        [Required]
        public int Salary { get; set; }
        public string Dept { get; set; }
    }
}
