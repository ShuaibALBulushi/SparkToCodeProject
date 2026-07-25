using System;
using System.Collections.Generic;
using System.Text;

namespace EFCorePractice.Models
{
    public class Employee
    {
        public int EmployeeId {  get; set; }
        public string Ssn { get; set; }
        public string EmployeeAddress { get; set; }
        public double EmplyeeSalary { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSex { get; set; }
        public DateTime EmployeeBDate { get; set; }

    }
}
