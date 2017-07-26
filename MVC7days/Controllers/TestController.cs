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
            EmployeeBusinessLayer empBusinessLayer = new EmployeeBusinessLayer();
            EmployeeListViewModel empListView = new EmployeeListViewModel();
            
            List<Employee> employeesList = empBusinessLayer.GetEmployees();
            List<EmployeeViewModel> empViewModelList = new List<EmployeeViewModel>();
            foreach(Employee emp in employeesList)
            {
                EmployeeViewModel empView = new EmployeeViewModel();
                empView.EmployeeName = emp.FirstName + " " + emp.LastName;
                empView.Salary = emp.Salary.ToString("C");

                if (emp.Salary >= 20000)
                {
                    empView.SalaryColor = "red";
                }
                 else
                {
                    empView.SalaryColor = "green";
                }

                //empListView.Employees.Add(empView);
                empViewModelList.Add(empView);
            }

            empListView.Employees = empViewModelList;
            empListView.UserName = "Admin";

            return View("MyView",empListView);
        }
        
        public string GetString()
        {
            return "Hallo World is old now. It's time for wassup bro";
        }
        
    }
}