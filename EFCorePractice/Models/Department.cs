using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCorePractice.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int DepartmentNumber { get; set; }

        //work for relationship 1-M
        [InverseProperty("department")]
        public List <Employee> Employee { get; set; }


        //Manage 1-1
        [ForeignKey("Emp")]
        public int EmployeeId { get; set; }
        public Employee Emp { get; set; }

        public DateTime ManageStartDate { get; set; }


        // control relationship 1-M
        public List<Project> Projects { get; set; }
    }
}
