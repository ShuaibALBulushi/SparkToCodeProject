using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCorePractice.Models
{
    [PrimaryKey(nameof(DepartmentId), nameof(DeptLocation))]
    public class DepartmentLocation
    {
        [ForeignKey("department")]
        public int DepartmentId { get; set; }
        public Department department { get; set; }

        public string DeptLocation { get; set; }
    }
}
