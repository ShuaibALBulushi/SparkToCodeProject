using EFCorePractice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCorePractice
{
    public class ProjectContext : DbContext
    {
        public DbSet<Employee> employees { set; get; }

        public DbSet<Department> departments { set; get; }

        public DbSet<Dependent> dependents { set; get; }

        public DbSet<Project> projects { set; get; }

        public DbSet<DepartmentLocation> departmentLocations { set; get; }

        public DbSet<EmployeeProject> employeeProjects { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
            "Server=.\\SQLEXPRESS;Database=CompanyDB;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }
    }
}
