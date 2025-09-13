using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Instructor
    {

        public int InsId { get; set; }
        public string InsName { get; set; }
        public int Bouns { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public decimal HourRate { get; set; }


        [InverseProperty(nameof(Department.Instructors))]
        [ForeignKey(nameof(DeptId))]
        public Department InsDepartment { get; set; }
        public int? DeptId { get; set; }



        [InverseProperty(nameof(Department.Manager))]
        public Department ManagedDepartment { get; set; }



        public ICollection<Course_Inst> CourseInstructors { get; set; } = new List<Course_Inst>();

    }
}
