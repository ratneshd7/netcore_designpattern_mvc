using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryDemoApp.DAL
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options) : base(options)
        {
          
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.HasDefaultSchema("dbo");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
