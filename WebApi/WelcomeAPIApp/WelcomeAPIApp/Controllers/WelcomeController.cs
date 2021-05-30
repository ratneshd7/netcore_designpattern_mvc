using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace WelcomeAPIApp.Controllers
{
    public class WelcomeController:ApiController
    {
        public IHttpActionResult Get()
        {
            //return Ok("Get Invoked");
            return Content((HttpStatusCode)422, "Get Invoked");//to invoke error response
        }
        public IHttpActionResult Post()
        {
            return Ok("Post Invoked");
           
        }
        public IHttpActionResult Put()
        {
            return Ok("Put Invoked");
        }
        public IHttpActionResult Delete()
        {
            return Ok("Delete Invoked");
        }
    }
}