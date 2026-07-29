using Microsoft.EntityFrameworkCore;
using WebAPIPractice.Models;

namespace WebAPIPractice
{
    public class ProjectContext : DbContext
    {
        DbSet<Employee> employees { get; set; }
        DbSet<Department> departments { get; set; }

        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {
        }
    }
}
