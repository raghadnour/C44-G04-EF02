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
    internal class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                  .HasColumnType("varchar(50)")
                  .IsRequired();

            builder.Property(x => x.Duration)
                   .IsRequired(false);

            builder.Property(x => x.Description)
                 .HasColumnType("varchar(150)")
                 .IsRequired(false);


                       
            builder.HasOne(x => x.Topic)
                   .WithMany(x => x.Courses)
                   .HasForeignKey(x => x.TopId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
