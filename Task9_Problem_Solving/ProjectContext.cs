using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Task9_Problem_Solving.Models;

namespace Task9_Problem_Solving
{
    public class ProjectContext : DbContext
    {
        // tables
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<ProductOrdered> orderedProducts { get; set; }
        public DbSet<Review> reviews { get; set; }
        public DbSet<User> users { get; set; }

        // connection
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
            "Server=.\\SQLEXPRESS;Database=e-commerceDB;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }
    }
}
