using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Course
    {
        public int Id { get; set; }
        public int? Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int TopId { get; set; }
        public Topic Topic { get; set; }


        public ICollection<Stud_Course> StudentCourses { get; set; } = new List<Stud_Course>();


        public ICollection<Course_Inst> CourseInstructors { get; set; } = new List<Course_Inst>();

    }
}
