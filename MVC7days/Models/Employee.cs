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
        //[Required(ErrorMessage = "Enter First Name")] // od lab 13
        [FirstNameValidation]//dodadeno lab 14
        public string FirstName { get; set; }
        [StringLength(12, ErrorMessage = "Last Name length should not be greater than 12")]
        public string LastName { get; set; }
        public int Salary { get; set; }
    }

    //dodadeno lab 14 - Custom Server Side Validation
    public class FirstNameValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("Please Provide First Name");
            }
            else
            {
                if (value.ToString().Contains("@"))
                {
                    return new ValidationResult("First Name should not conatain @");
                }
            }

            return ValidationResult.Success;
        }


    }
}