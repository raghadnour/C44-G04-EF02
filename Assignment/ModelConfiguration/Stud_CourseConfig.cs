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
    internal class Stud_CourseConfig : IEntityTypeConfiguration<Stud_Course>
    {
        public void Configure(EntityTypeBuilder<Stud_Course> builder)
        {
            builder.HasKey(x => new { x.StudentId, x.CourseId });

            builder.HasOne(x => x.Student)
              .WithMany(x => x.StudentCourses)
              .HasForeignKey(x => x.StudentId);

            builder.HasOne(x => x.Course)
              .WithMany(x => x.StudentCourses)
              .HasForeignKey(x => x.CourseId);
        }
    }
}
