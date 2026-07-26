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
        public string EmployeeBDate { get; set; }

        //work for relationship 1-M
        public List<Department> department {  get; set; }

    }
}
