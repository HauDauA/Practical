using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace Exam2.Models
{
    public class Employee
    {
        [Key]
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
    }
}