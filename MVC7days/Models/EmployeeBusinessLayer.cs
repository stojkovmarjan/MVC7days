using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC7days.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee
                {
                    FirstName = "Maryan",
                    LastName = "Stoykov",
                    Salary = 19000
                },
                new Employee
                {
                    FirstName = "Petko",
                    LastName = "Trayanov",
                    Salary = 17000
                },
                new Employee
                {
                    FirstName = "Roger",
                    LastName = "Moore",
                    Salary = 29000
                },
                new Employee
                {
                    FirstName = "Bob",
                    LastName = "Silent",
                    Salary = 12000
                }
        };

            return employees;
        }
        

    }
}