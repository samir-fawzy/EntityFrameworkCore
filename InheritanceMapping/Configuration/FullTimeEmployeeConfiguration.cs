using InheritanceMapping.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMapping.Configuration
{
    internal class FullTimeEmployeeConfiguration : IEntityTypeConfiguration<FullTimeEmployee>
    {
        public void Configure(EntityTypeBuilder<FullTimeEmployee> builder)
        {
            builder.Property(E => E.Salary).HasColumnType("decimal(7,2)");
            builder.HasBaseType<Employee>();
        }
    }
}
