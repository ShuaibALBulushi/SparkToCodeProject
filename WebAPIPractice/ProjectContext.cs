using Microsoft.EntityFrameworkCore;
using WebAPIPractice.Models;

namespace WebAPIPractice
{
    public class ProjectContext : DbContext
    {
        public DbSet<Employee> employees { get; set; }
        public DbSet<Department> departments { get; set; }

        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {
        }
    }
}
