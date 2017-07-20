﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC7days.Controllers
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public override string ToString()
        {
            return this.CustomerName + "|" + this.Address;
        }
    }

    public class TestController : Controller
    {
        
        public Customer GetCustomer()
        {
            Customer c = new Customer
            {
                CustomerName = "rtetertret",
                Address = "sdsdsdsd"
            };

            return c;
        }

        public ActionResult GetView()
        {
            return View("MyView");
        }

    }

}