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

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
            "Server=.;Database=CompanyDB;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }
    }
}
