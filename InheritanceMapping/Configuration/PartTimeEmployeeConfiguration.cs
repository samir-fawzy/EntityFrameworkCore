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
    internal class PartTimeEmployeeConfiguration : IEntityTypeConfiguration<PartTimeEmployee>
    {
        public void Configure(EntityTypeBuilder<PartTimeEmployee> builder)
        {
            builder.Property(E => E.HourRate).HasColumnType("decimal(6,2)");
            builder.HasBaseType<Employee>();
        }
    }
}
