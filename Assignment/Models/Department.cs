using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public DateTime? HiringDate { get; set; }


        public ICollection<Student> Students { get; set; }

        [InverseProperty(nameof(Instructor.InsDepartment))]
        public ICollection<Instructor> Instructors { get; set; }


        [InverseProperty(nameof(Instructor.ManagedDepartment))]
        [ForeignKey(nameof(ManagerId))]
        public Instructor Manager { get; set; }
        public int? ManagerId { get; set; }
    }
}
