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

    }
}
