using EntityFrameworkCore.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Configurations
{
    internal class CourseConfiguration: IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> c)
        {
            c.HasKey(c => c.Id);

            c.Property(c => c.Id).IsRequired(true).UseIdentityColumn(1, 1);

            c.HasMany(c => c.CourseStudents).WithOne(Sc => Sc.Course);
        }
    }
}
