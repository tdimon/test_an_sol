using Microsoft.EntityFrameworkCore;

namespace WebAPIApp.Models
{
    public class MainContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public MainContext(DbContextOptions<MainContext> options)
            : base(options)
        {
            bool result = Database.EnsureCreated();
            //if (result)
            //    Initialize.InitializeData(this);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
            new Department[]
            {
                new Department { Id = 1, Name = "Отдел продаж" },
                new Department { Id = 2, Name = "Отдел закупок" },
                new Department { Id = 3, Name = "Бухгалтерия" },
                new Department { Id = 4, Name = "Отдел логистики" },
                new Department { Id = 5, Name = "Отдел маркетинга" }
            });

            modelBuilder.Entity<Employee>().HasData(
           new Employee[]
           {                
                new Employee { Id = 1, Name = "Евгения", Salary = 1500, DepartmentId = 2 },
                new Employee { Id = 2, Name = "Виктория", Salary = 1200, DepartmentId = 3 },
                new Employee { Id = 3, Name = "Анастасия", Salary = 1350, DepartmentId = 4 },
                new Employee { Id = 4, Name = "Демид", Salary = 900, DepartmentId = 5 },
                new Employee { Id = 5, Name = "Злата", Salary = 1800, DepartmentId = 1 },
                new Employee { Id = 6, Name = "Никита", Salary = 750, DepartmentId = 2 },
                new Employee { Id = 7, Name = "Роман", Salary = 1200, DepartmentId = 3 },
                new Employee { Id = 8, Name = "Тимофей", Salary = 1620, DepartmentId = 4 },
                new Employee { Id = 9, Name = "Милана", Salary = 1700, DepartmentId = 5 },
                new Employee { Id = 10, Name = "Мария", Salary = 850, DepartmentId = 1 },
                new Employee { Id = 11, Name = "Ева", Salary = 910, DepartmentId = 2 },
                new Employee { Id = 12, Name = "София", Salary = 1050, DepartmentId = 3 },
                new Employee { Id = 13, Name = "Егор", Salary = 1100, DepartmentId = 4 },
                new Employee { Id = 14, Name = "Юрий", Salary = 1900, DepartmentId = 5 },
                new Employee { Id = 15, Name = "Александр", Salary = 1600, DepartmentId = 1 },
                new Employee { Id = 16, Name = "Дарья", Salary = 1850, DepartmentId = 2 },
                new Employee { Id = 17, Name = "Елисей", Salary = 1900, DepartmentId = 3 },
                new Employee { Id = 18, Name = "Иван", Salary = 2000, DepartmentId = 4 },
                new Employee { Id = 19, Name = "Фёдор", Salary = 1250, DepartmentId = 5 },
                new Employee { Id = 20, Name = "Даниил", Salary = 1000, DepartmentId = 1 },
                new Employee { Id = 21, Name = "Мирослава", Salary = 1350, DepartmentId = 2 },
                new Employee { Id = 22, Name = "Владимир", Salary = 1400, DepartmentId = 3 },
                new Employee { Id = 23, Name = "Семён", Salary = 1000, DepartmentId = 4 },
                new Employee { Id = 24, Name = "Анна", Salary = 1100, DepartmentId = 5 },
                new Employee { Id = 25, Name = "Максим", Salary = 1950, DepartmentId = 1 },
                new Employee { Id = 26, Name = "Маргарита", Salary = 1600, DepartmentId = 2 },
                new Employee { Id = 27, Name = "Павел", Salary = 1250, DepartmentId = 3 },
                new Employee { Id = 28, Name = "Георгий", Salary = 1300, DepartmentId = 4 },
                new Employee { Id = 29, Name = "Майя", Salary = 1000, DepartmentId = 5 },
                new Employee { Id = 30, Name = "Дмитрий", Salary = 1000, DepartmentId = 1}
        });
        }
    }
}