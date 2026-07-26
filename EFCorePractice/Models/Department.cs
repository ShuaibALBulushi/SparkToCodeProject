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
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
    }
}
