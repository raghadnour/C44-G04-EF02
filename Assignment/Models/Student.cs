using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int? Age { get; set; }

        public int? DepId { get; set; }
        public Department Department { get; set; }



        public ICollection<Stud_Course> StudentCourses { get; set; } = new List<Stud_Course>();


    }
}
