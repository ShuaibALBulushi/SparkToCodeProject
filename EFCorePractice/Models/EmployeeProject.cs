using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCorePractice.Models
{
    public class EmployeeProject
    {
        // work on
        [ForeignKey("emp")]
        public int EmployeeId { get; set; }
        public Employee emp {  get; set; }

        // work on
        [ForeignKey("project")]
        public int ProjectNumber { get; set; }
        public Project project { get; set; }


        public int ProjectHours { get; set; }
    }
}
