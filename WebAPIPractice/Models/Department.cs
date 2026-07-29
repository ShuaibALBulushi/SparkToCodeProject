using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebAPIPractice.Models
{
    public class Department
    {
        [Key]
        [JsonIgnore]
        public int DepartmentId { get; set; }
        [Required]
        public string DepartmentName { get; set; }
        [Required]
        public int DepartmentNumber { get; set; }

        //work for relationship 1-M
        [JsonIgnore]
        public List<Employee>? Employee { get; set; }
    }
}
