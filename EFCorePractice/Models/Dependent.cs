using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCorePractice.Models
{
    public class Dependent
    {
        public string DependentName { get; set; }
        public string DependentSex { get; set; }
        public string DependentBirthDate { get; set; }
        public string DependentRelationship { get; set; }

        // dependent of 1-1
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
