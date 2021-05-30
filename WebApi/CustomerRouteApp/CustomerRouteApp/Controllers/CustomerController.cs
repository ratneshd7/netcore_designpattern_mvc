using CustomerRouteApp.Models;
using CustomerRouteApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CustomerRouteApp.Controllers
{
    [RoutePrefix("api/v1/Customer")]
    public class CustomerController : ApiController
    {
        CustomerService customerService = CustomerService.GetInstance();
        [Route("GetCustomers")]
        public IHttpActionResult GetCustomers()
        {
            return Ok(customerService.Get());
        }
        [Route("GetCustomerById/{customerId:Guid}")]
        public IHttpActionResult GetCustomerById(Guid customerId)
        {
            var data = customerService.Get(customerId);
            if (data== null)
            {
                return NotFound();
            }
            return Ok(data);
        }
        [Route("AddCustomer")]
        public IHttpActionResult AddCustomer(Customer customerDTO)
        {
            Customer c1 = new Customer(Guid.NewGuid(),customerDTO.FirstName,customerDTO.LastName,customerDTO.Location);
            customerService.Add(c1);
            return Ok(c1.Id);
        }
        [Route("DeleteCustomerById/{customerId:Guid}")]
        public IHttpActionResult DeleteCustomerById(Guid customerId)
        {
            customerService.Delete(customerId);
            return Ok("Deleted Successfully");
        }
        [Route("UpdateCustomerById/{customerId:Guid}")]
        public IHttpActionResult PutCustomerById(Guid customerId, Customer customerDTO)
        {
            Customer c1 = new Customer(customerId, customerDTO.FirstName, customerDTO.LastName, customerDTO.Location);
            customerService.Update(c1);
            return Ok("Updated Successfully");
        }
        [Route("GetCustomerListByPageNo/{pageno:int}/{pagesize:int}")]
        public IHttpActionResult GetCustomerListByPageNo(int pageno,int pagesize)
        {
            if (pageno==0)
            {
                pageno = 1;
            }
            return Ok(customerService.GetCustomerByPageNo(pageno, pagesize));
        }

    }
}
