using Microsoft.AspNetCore.Mvc;
using System.Security.AccessControl;
using WebAPIPractice.Models;

namespace WebAPIPractice.Controllers
{
    [ApiController]
    [Route("Employee")]
    public class EmployeeController : ControllerBase
    {
        private ProjectContext context;

        public EmployeeController(ProjectContext _context)
        {
            context = _context;
        }



        [HttpPost("AddEmployee")]
        public IActionResult AddEmployee(Employee emp)
        {
            context.employees.Add(emp);
            context.SaveChanges();

            return Ok(emp.EmployeeId);
        }



        [HttpPatch("UpdateEmployeeName")]
        public IActionResult UpdateEmployeeName(int id, string name)
        {
            Employee emp = context.employees.FirstOrDefault(e => e.EmployeeId == id);

            emp.EmployeeName = name;
            context.SaveChanges();

            return Ok($"Employee name successfully changed to {emp.EmployeeName}");
        }



        [HttpDelete("DeleteEmployeeById")]
        public IActionResult DeleteEmployeeById(int id)
        {
            Employee emp = context.employees.FirstOrDefault(e => e.EmployeeId == id);
            
            if(emp != null)
            {
                context.employees.Remove(emp);
                context.SaveChanges();

                return Ok("Employee successfully deleted");
            }
            else
            {
                return NotFound("Employee not found");
            }
        }

    }
}
