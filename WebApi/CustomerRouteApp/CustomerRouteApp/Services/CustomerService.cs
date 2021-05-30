using CustomerRouteApp.Models;
using CustomerRouteApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerRouteApp.Services
{
    public class CustomerService
    {
        private CustomerRepository _repo = null;
        //public static List<Customer> CustomerList = new List<Customer>();
        private  CustomerService(){
            _repo = new CustomerRepository();
        }
        public static CustomerService cserv = null;
        public static CustomerService GetInstance()
        {

            if (cserv==null)
            {
                cserv = new CustomerService();
                //CreateList();
            }
            return cserv;
        }
        public List<Customer> Get()
        {
            //return CustomerList;
            return _repo.GetCustomer();
        }
        public Customer Get(Guid id)
        {
            //return CustomerList.Where(list=>list.Id == id);
            return _repo.GetCustomerById(id);
        }
        //private static void CreateList()
        //{
        //    CustomerList.Add(new Customer(Guid.NewGuid(), "Ratnesh", "Dubey", "Andheri"));
        //    CustomerList.Add(new Customer(Guid.NewGuid(), "Hiren", "More", "Andheri"));
        //    CustomerList.Add(new Customer(Guid.NewGuid(), "Onkar", "walvalkar", "Andheri"));
        //}
        public void Add(Customer c1)
        {
            //CustomerList.Add(c1);
            _repo.AddCustomer(c1);
        }
        public void Delete(Guid id)
        {
            //CustomerList.Remove(CustomerList.Single(s => s.Id == id));
            _repo.DeleteCustomerById(id);
        }
        public void Update(Customer c1)
        {
            //foreach (var c in CustomerList.Where(l => l.Id == c1.Id))
            //{
            //    c.FirstName = c1.FirstName;
            //    c.LastName = c1.LastName;
            //    c.Location = c1.Location;
            //}
            _repo.EditCustomer(c1);
        }
        public List<Customer> GetCustomerByPageNo(int CurrentPage,int PageSize)
        {
            //return CustomerList.Skip((CurrentPage - 1) * PageSize).Take(PageSize).ToList();
            return _repo.GetCustomerByPageNo(CurrentPage, PageSize);
        }
    }
}