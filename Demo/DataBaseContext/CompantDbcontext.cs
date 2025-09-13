using Demo.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataBaseContext
{
    internal class CompantDbcontext: DbContext
    {
        public CompantDbcontext(): base()
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration<Employee>(new ModelConfiguration.EmloyeeConfig());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());// to apply all fluent APIs

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            //optionsBuilder.UseSqlServer("Data source =. ; Intial Catlog = CompanyG03 ; Integrated Security : True");
            optionsBuilder.UseSqlServer("server=. ;database=CompanyG03 ;Trusted_Connection = True;TrustServerCertificate = True ");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
