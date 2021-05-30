using CustomerRouteApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CustomerRouteApp.Repositories
{
    public class CustomerRepository:DbContext
    {
        public DbSet<Customer> CustomerList { get; set; }
        public void AddCustomer(Customer c1)
        {
            this.CustomerList.Add(c1);
            this.SaveChanges();
        }
        public void EditCustomer(Customer c1)
        {
            var updateCustomer = this.CustomerList.SingleOrDefault(x => x.Id == c1.Id);
            if (updateCustomer != null)
            {

                updateCustomer.Id = c1.Id;
                updateCustomer.FirstName = c1.FirstName;
                updateCustomer.LastName = c1.LastName;
                updateCustomer.Location = c1.Location;
                this.SaveChanges();
            }
        }
        public List<Customer> GetCustomer()
        {
            return this.CustomerList.ToList();
        }
        public Customer GetCustomerById(Guid id)
        {
            return this.CustomerList.Where(c=>c.Id==id).FirstOrDefault();
        }
        public void DeleteCustomerById(Guid id)
        {
            var deleteCustomer = this.CustomerList.SingleOrDefault(x => x.Id == id);
            if (deleteCustomer !=null)
            {
                this.CustomerList.Remove(deleteCustomer);
                this.SaveChanges();
            }
        }
        public List<Customer> GetCustomerByPageNo(int CurrentPage, int PageSize)
        {
            try
            {
                var clist = this.CustomerList.OrderBy(c => c.Id).Skip((CurrentPage - 1) * PageSize).Take(PageSize).ToList();
                return clist;
            }
            catch (Exception e)
            {
                return null;
            }
        }

    }
}