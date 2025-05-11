using EntityFrameworkCore.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Configurations
{
    internal class StudentCourseConfiguration: IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> sc)
        {
            sc.HasKey(sc => new { sc.StudentId, sc.CourseId });
            sc.HasOne(sc => sc.Student)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.StudentId);
            sc.HasOne(sc => sc.Course)
                .WithMany(c => c.CourseStudents)
                .HasForeignKey(sc => sc.CourseId);
        }
    }
}
