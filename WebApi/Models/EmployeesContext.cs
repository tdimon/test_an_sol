using Microsoft.EntityFrameworkCore;

namespace WebAPIApp.Models
{
    public class EmployeesContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public EmployeesContext(DbContextOptions<EmployeesContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}