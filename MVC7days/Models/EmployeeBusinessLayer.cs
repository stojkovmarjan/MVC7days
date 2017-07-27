using MVC7days.DataAccessLayer;
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
            Mvc5in7daysDB mvc5In7DAYS = new Mvc5in7daysDB();
            return mvc5In7DAYS.Employees.ToList();
        }
        

    }
}