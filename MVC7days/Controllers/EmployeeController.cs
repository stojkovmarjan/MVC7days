using MVC7days.Models;
using MVC7days.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC7days.Controllers
{
    public class EmployeeController : Controller
    {
   
        public ActionResult Index()
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
            
            return View("Index",empListView);
        }
        
        public ActionResult AddNew()
        {
            return View("CreateEmployee");
        }   
        
        public ActionResult SaveEmployee(Employee e, string BtnSubmit)
        {
            switch (BtnSubmit)
            {
                case "Save Employee":
                    //return Content(e.FirstName + "|" + e.LastName + "|" + e.Salary);
                    EmployeeBusinessLayer empBLayer = new EmployeeBusinessLayer();
                    empBLayer.SaveEmployee(e);
                    return RedirectToAction("Index");
                case "Cancel":
                    return RedirectToAction("Index");
            }

            return new EmptyResult();
        }
    }
}