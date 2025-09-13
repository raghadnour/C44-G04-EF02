using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Topic
    {
        public int TopId { get; set; }
        public string TopName { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
