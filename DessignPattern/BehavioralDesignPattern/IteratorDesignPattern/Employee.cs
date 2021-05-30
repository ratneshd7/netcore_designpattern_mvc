using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Employee(string name, int id)
        {
            Name = name;
            ID = id;
        }
    }
}
