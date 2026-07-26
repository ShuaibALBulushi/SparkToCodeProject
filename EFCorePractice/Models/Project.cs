using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCorePractice.Models
{
    public class Project
    {
        public int ProjectNumber { get; set; }
        public string ProjecutorName { get; set; }
        public string ProjectLocation { get; set; }


        //work on M-M
        public List<EmployeeProject> EmpProjects { get; set; }


        // control relationship 1-M
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}
