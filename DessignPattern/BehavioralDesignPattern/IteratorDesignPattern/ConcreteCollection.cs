using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern
{
    class ConcreteCollection : IAbstractCollection
    {
        private List<Employee> listEmployees = new List<Employee>();
        //Create Iterator
        public Iteratorclas CreateIterator()
        {
            return new Iteratorclas(this);
        }
        // Gets item count
        public int Count
        {
            get { return listEmployees.Count; }
        }
        //Add items to the collection
        public void AddEmployee(Employee employee)
        {
            listEmployees.Add(employee);
        }
        //Get item from collection
        public Employee GetEmployee(int IndexPosition)
        {
            return listEmployees[IndexPosition];
        }
    }
}
