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
    internal class TopicConfig : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            builder.HasKey(x => x.TopId);

            builder.Property(x => x.TopName)
                   .HasColumnType("varchar(50)")
                   .IsRequired();


            builder.HasMany(x => x.Courses)
                   .WithOne(x => x.Topic)
                   .HasForeignKey(x => x.TopId)
                   .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
