using Assignment.DataBaseContext;
using Assignment.Models;
using Microsoft.EntityFrameworkCore;
using System.Windows.Markup;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using RouteDbContext Dbcontext = new RouteDbContext();

            #region ADD
            Department dept1 = new Department()
            {
                DeptName = "SC",
                HiringDate = DateTime.Now

            };
            Department dept2 = new Department()
            {
                DeptName = "IT",
                HiringDate = DateTime.Now
            };
            Department dept3 = new Department()
            {
                DeptName = "Network",
                HiringDate = DateTime.Now
            };
            Dbcontext.Add(dept1);
            Dbcontext.Add(dept2);
            Dbcontext.Add(dept3);
            Dbcontext.SaveChanges();


            Student st1 = new Student()
            {
                FirstName = "Ali",
                LastName = "Ahmed",
                Address = "Cairo",
                Age = 22,
                DepId = 1
            };
            Student st2 = new Student()
            {
                FirstName = "aya",
                LastName = "mohamed",
                Address = "assuit",
                Age = 25,
                DepId = 2
            };
            Dbcontext.Add(st1);
            Dbcontext.Add(st2);
            Dbcontext.SaveChanges();

            #endregion

            #region Read
            //var students = Dbcontext.Students.AsNoTracking().FirstOrDefault(s => s.Id == 1);
            //if (students is not null)
            //{
            //    Console.WriteLine($"ID: {students.Id}, Name: {students.FirstName} {students.LastName}, Address: {students.Address}, Age: {students.Age}, Department ID: {students.DepId}");
            //}
            //else
            //{
            //    Console.WriteLine("Student not found.");
            //}
            //var departments = Dbcontext.Departments.AsNoTracking().FirstOrDefault(d => d.DeptId == 1);
            //if (departments is not null)
            //{
            //    Console.WriteLine($"ID: {departments.DeptId}, Name: {departments.DeptName}, Hiring Date: {departments.HiringDate}");
            //}
            //else
            //{
            //    Console.WriteLine("Department not found.");
            //} 
            #endregion

            #region Modify
            var student = Dbcontext.Students.FirstOrDefault(s => s.Id == 1);
            if (student is not null)
            {
                student.FirstName = "Omar";
                Dbcontext.SaveChanges();
            }
            var departments = Dbcontext.Departments.FirstOrDefault(d => d.DeptId == 3);
            if (departments is not null)
            {
                departments.DeptName = "IS";
                Dbcontext.SaveChanges();
            }
            #endregion

            #region Delete
            var student02 = Dbcontext.Students.FirstOrDefault(s => s.Id == 2);
            if (student02 is not null)
            {
                Dbcontext.Remove(student02);
                Dbcontext.SaveChanges();
            }
            var departments02 = Dbcontext.Departments.FirstOrDefault(d => d.DeptId == 3);
            if (departments02 is not null)
            {
                Dbcontext.Remove(departments02);
                Dbcontext.SaveChanges();
            }
        } 
        #endregion

    }
}
