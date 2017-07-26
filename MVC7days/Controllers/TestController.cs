using MVC7days.Models;
using MVC7days.ViewModels;
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
                Salary = 19000
            };

            EmployeeViewModel empView = new EmployeeViewModel();

            empView.EmployeeName = emp.FirstName + " " + emp.LastName;
            empView.Salary = emp.Salary.ToString("C");
            if (emp.Salary >= 20000)
            {
                empView.SalaryColor = "red";
            }
                else empView.SalaryColor = "green";

            empView.UserName = "Admin";

            return View("MyView",empView);
        }
        public string GetString()
        {
            return "Hallo World is old now. It's time for wassup bro";
        }
        
    }
}