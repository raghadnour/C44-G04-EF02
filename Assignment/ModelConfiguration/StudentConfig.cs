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
    internal class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);

            builder.Property(x => x.FirstName)
                   .HasColumnType("varchar(10)")
                   .IsRequired();

            builder.Property(x => x.LastName)
                   .HasColumnType("varchar(10)")
                   .IsRequired(false);

            builder.Property(x => x.Address)
                   .HasColumnType("varchar(150)")
                   .IsRequired();

            builder.Property(x => x.Age)
                   .IsRequired();


            builder.HasOne(x => x.Department)
                   .WithMany(x => x.Students)
                   .HasForeignKey(x => x.DepId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
