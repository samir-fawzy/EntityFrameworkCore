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
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {

        public void Configure(EntityTypeBuilder<Department> d)
        {
            
            d.HasKey(d => d.DepId);

            d.Property(d => d.DepId).UseIdentityColumn(1, 1);

            d.Property(d => d.DepName).IsRequired().HasMaxLength(50);

            d.Property(d => d.CreatedDate).IsRequired();

            d.HasMany(D => D.Employees).WithOne(E => E.Department).IsRequired(false).HasForeignKey(E => E.DepartmentId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
