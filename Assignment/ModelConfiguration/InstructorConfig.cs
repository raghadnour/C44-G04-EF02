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
    internal class InstructorConfig : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(x => x.InsId);

            builder.Property(x => x.InsName)
                   .HasColumnType("varchar(50)")
                   .IsRequired();

            builder.Property(x => x.Bouns);

            builder.Property(x => x.Salary)
                    .HasPrecision(10, 3);

            builder.Property(x => x.Address)
                   .HasColumnType("varchar(50)");

            builder.Property(x => x.HourRate)
                   .HasPrecision(5, 3);


            builder.HasOne(x => x.InsDepartment)
                   .WithMany(x => x.Instructors)
                   .HasForeignKey(x => x.DeptId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.ManagedDepartment)
                    .WithOne(x => x.Manager)
                    .HasForeignKey<Department>(x => x.ManagerId)
                    .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
