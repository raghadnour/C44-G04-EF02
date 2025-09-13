using Demo.DataBaseContext;
using Demo.Model;
using Microsoft.EntityFrameworkCore;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //using CompantDbcontext dbcontext = new CompantDbcontext();
            //Employee emp=new Employee() { Name = "Ahmed", Salary = 5000, Age = 30 };
            ////Console.WriteLine(dbcontext.Entry<Employee>(emp).State);
            #region ADD
            //add in 4 ways
            //dbcontext.Employees.Add(emp);
            ////dbcontext.Set<Employee>().Add(emp);
            ////dbcontext.Entry<Employee>(emp).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            ////dbcontext.Add(emp);
            ///

            //Console.WriteLine("after add in dbset " + dbcontext.Entry<Employee>(emp).State);
            //dbcontext.SaveChanges();
            //Console.WriteLine("after save changes " + dbcontext.Entry<Employee>(emp).State);

            #endregion

            #region Modifiy

            //var e1=dbcontext.Employees.AsNoTracking().FirstOrDefault(e => e.Name=="Ahmed");
            //if(e1 is not null)
            //{
            //    Console.WriteLine("before modify " + dbcontext.Entry<Employee>(e1).State);
            //    e1.Name = "Raghad";
            //    Console.WriteLine("after modify " + dbcontext.Entry<Employee>(e1).State);
            //    dbcontext.SaveChanges();
            //    Console.WriteLine("after save changes " + dbcontext.Entry<Employee>(e1).State);
            //}
            #endregion

            #region Deleted
            //var e1 = dbcontext.Employees.FirstOrDefault(e => e.Name == "Raghad");
            //if (e1 is not null)
            //{
            //    Console.WriteLine("before delete " + dbcontext.Entry<Employee>(e1).State);
            //    dbcontext.Employees.Remove(e1);
            //    //dbcontext.Entry<Employee>(e1).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            //    //dbcontext.Remove(e1);
            //    //dbcontext.Set<Employee>().Remove(e1);
            //    Console.WriteLine("after delete " + dbcontext.Entry<Employee>(e1).State);
            //    dbcontext.SaveChanges();
            //    Console.WriteLine("after save changes " + dbcontext.Entry<Employee>(e1).State);
            //}
            #endregion



        }
    }
}
