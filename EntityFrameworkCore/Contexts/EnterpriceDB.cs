using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkCore.Configurations;
using EntityFrameworkCore.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Abstractions;

namespace EntityFrameworkCore.Contexts
{
    internal class EnterpriceDB : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Department>(new DepartmentConfiguration());

            modelBuilder.ApplyConfiguration<Student>(new StudentConfiguration());

            modelBuilder.ApplyConfiguration<Course>(new CourseConfiguration());

            modelBuilder.ApplyConfiguration<StudentCourse>(new StudentCourseConfiguration());      
            modelBuilder.Entity<EmployeeDepartmentView>().ToView("EmployeeDepartmentView").HasNoKey();

            modelBuilder.Entity<StudentCourseView>().ToView("StudentCourseView").HasNoKey();
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=SAMIR;Database=EnterpriceDB;Trusted_Connection=true;TrustServerCertificate=true");
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=SAMIR;Database=EnterpriceDB;Trusted_Connection=true;TrustServerCertificate=true");



        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<EmployeeDepartmentView> EmployeeDepartmentView { get; set; }
        public DbSet<StudentCourseView> studentCourseView { get; set; }
    }
}
