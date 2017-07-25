using MVC7days.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC7days.Controllers
{
    public class TestController : Controller
    {
        /* GET: Test
        public ActionResult Index()
        {
            return View();
        }
        */
        public ActionResult GetView()
        {
            Employee emp = new Employee
            {
                FirstName = "Maryan",
                LastName = "Stoykov",
                Salary = 20000
            };

            ViewBag.Employee = emp; //.Employee si go stavas sam

            return View("MyView", emp);
        }
        public string GetString()
        {
            return "Hallo World is old now. It's time for wassup bro";
        }
        
    }
}