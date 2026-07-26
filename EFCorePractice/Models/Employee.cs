using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        [ForeignKey("department")]
        public int DepartmentId { get; set; }
        public Department department {  get; set; }

        //Manage 1-1
        [InverseProperty("Emp")]
        public List<Department> dept { get; set; }


        // supervision self-relationship

        [InverseProperty("supervisor")]
        public List<Employee> employees { get; set; }


        [ForeignKey("supervisor")]
        public int SupervisorId { get; set; }
        public Employee supervisor { get; set; }

    }
}
