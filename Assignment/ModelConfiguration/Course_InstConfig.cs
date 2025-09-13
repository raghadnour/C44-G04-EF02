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
    internal class Course_InstConfig : IEntityTypeConfiguration<Course_Inst>
    {
        public void Configure(EntityTypeBuilder<Course_Inst> builder)
        {
            builder.HasKey(x => new { x.InstructorId, x.CourseId });

            builder.HasOne(x => x.Instructor)
                  .WithMany( x => x.CourseInstructors)
                  .HasForeignKey(x => x.InstructorId);

            builder.HasOne(x => x.Course)
                   .WithMany(x => x.CourseInstructors)
                   .HasForeignKey(x => x.CourseId);
        }
    }
}
