using Assignment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ModelConfiguration
{
    internal class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(x => x.DeptId);

            builder.Property(x => x.DeptName)
                   .HasColumnType("varchar(50)");

            builder.Property(x => x.HiringDate)
                   .HasColumnType("date");

             builder.HasMany(x => x.Students)
                    .WithOne(x => x.Department)
                    .HasForeignKey(x => x.DepId)
                    .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Instructors)
                   .WithOne(x => x.InsDepartment)
                   .HasForeignKey(x => x.DeptId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Manager)
                   .WithOne(x => x.ManagedDepartment)
                   .HasForeignKey<Department>(x => x.ManagerId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    
    }
}
