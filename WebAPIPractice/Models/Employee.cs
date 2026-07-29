using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebAPIPractice.Models
{
    public class Employee
    {
        [Key]
        [JsonIgnore]
        public int EmployeeId { get; set; }

        [Required]
        public string EmployeeAddress { get; set; }

        [Required]
        public double EmplyeeSalary { get; set; }

        [Required]
        public string EmployeeName { get; set; }

        [Required]
        public string EmployeeGender { get; set; }

        //work for relationship 1-M
        [ForeignKey("department")]
        [Required]
        public int DepartmentId { get; set; }

        [JsonIgnore]
        public Department? department { get; set; }
    }
}
