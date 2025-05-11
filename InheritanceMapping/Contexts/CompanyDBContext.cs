using InheritanceMapping.Configuration;
using InheritanceMapping.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMapping.Contexts
{   
    internal class CompanyDBContext:DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new FullTimeEmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new PartTimeEmployeeConfiguration());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=CompanyDB;Trusted_Connection=true;TrustServerCertificate=true");
        }
        public DbSet<Employee> Employees { get; set; }

    }
}
