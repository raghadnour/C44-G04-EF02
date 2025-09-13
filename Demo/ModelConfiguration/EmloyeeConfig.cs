using Demo.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.ModelConfiguration
{
    internal class EmloyeeConfig: IEntityTypeConfiguration<Employee>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("EmpId");
            builder.Property(e => e.Name).HasColumnName("EmpName").HasMaxLength(50).IsRequired();
            builder.Property(e => e.Salary).HasColumnName("EmpSalary").IsRequired();
            builder.Property(e => e.Age).HasColumnName("EmpAge");
            builder.ToTable(T => T.HasCheckConstraint("Range_Age", "[EmpAge] between 20 and 35"));
        }
    }
}
