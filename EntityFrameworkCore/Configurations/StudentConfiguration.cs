using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkCore.Entites;
namespace EntityFrameworkCore.Configurations
{
    internal class StudentConfiguration: IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> s)
        {

                s.HasKey(s => s.Id);
                s.Property(s => s.Id).IsRequired(true).UseIdentityColumn(1, 1);
                s.HasMany(s => s.StudentCourses).WithOne(Sc => Sc.Student);
      
        }
    }
}
