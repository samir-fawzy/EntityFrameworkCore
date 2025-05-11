using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace EntityFrameworkCore.Entites
{
    public class Employee : IEqualityComparer<Employee>
    {
        // Employee class represents the Employee table in the database
        // It contains properties that map to the columns in the Employee table
        // The class also contains navigation properties for relationships with other tables
        // Properties of the Employee class
        // EmpId is the primary key and is auto-incremented by the database

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpId { get; set; }
        [Required]
        [StringLength(50)] // Maximum length of Name is 50 characters
        public string Name { get; set; }
        [Phone]
        public decimal Salary { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        // Relationshit between Employee and Department is one to many
        // Foreign key in Employee table
        // Navigation property


        //[ForeignKey("Department")]
        public int? DepartmentId { get; set; } // Foreign key property

        //[InverseProperty("Employees")]
        public virtual Department Department { get; set; } // Navigation property

        

        public bool Equals(Employee? x, Employee? y)
        {
            if (x?.Name == y?.Name && x?.Email == y?.Email && x?.DateOfBirth == y?.DateOfBirth && x?.Salary == y?.Salary)
                return true;

            return false;

        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return HashCode.Combine(obj.Name, obj.Email, obj.DateOfBirth, obj.Salary);
        }
    }
}
