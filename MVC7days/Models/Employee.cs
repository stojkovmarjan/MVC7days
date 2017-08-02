using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC7days.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage ="Enter First Name")]
        public string FirstName { get; set; }
        [StringLength(12,ErrorMessage ="Last Name length should not be greater than 12")]
        public string LastName { get; set; }
        public int Salary { get; set; }
    }
}