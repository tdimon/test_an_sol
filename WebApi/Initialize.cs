using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIApp.Models
{
    public class Initialize
    {
        public static void InitializeData(MainContext context)
        {
            if (!context.Departments.Any())
            {
                context.Departments.Add(new Department { Name = "Отдел продаж" });
                context.Departments.Add(new Department { Name = "Отдел закупок" });
                context.Departments.Add(new Department { Name = "Бухгалтерия" });
                context.Departments.Add(new Department { Name = "Отдел логистики" });
                context.Departments.Add(new Department { Name = "Отдел маркетинга" });
                context.SaveChanges();
            }

            if (!context.Employees.Any())
            {
                context.Employees.Add(new Employee { Name = "Дмитрий", Salary = 1000, DepartmentId = 1});
                context.Employees.Add(new Employee { Name = "Евгения", Salary = 1500, DepartmentId = 2 });
                context.Employees.Add(new Employee { Name = "Виктория", Salary = 1200, DepartmentId = 3 });
                context.Employees.Add(new Employee { Name = "Анастасия", Salary = 1350, DepartmentId = 4 });
                context.Employees.Add(new Employee { Name = "Демид", Salary = 900, DepartmentId = 5 });
                context.Employees.Add(new Employee { Name = "Злата", Salary = 1800, DepartmentId = 1 });
                context.Employees.Add(new Employee { Name = "Никита", Salary = 750, DepartmentId = 2 });
                context.Employees.Add(new Employee { Name = "Роман", Salary = 1200, DepartmentId = 3 });
                context.Employees.Add(new Employee { Name = "Тимофей", Salary = 1620, DepartmentId = 4 });
                context.Employees.Add(new Employee { Name = "Милана", Salary = 1700, DepartmentId = 5 });
                context.Employees.Add(new Employee { Name = "Мария", Salary = 850, DepartmentId = 1 });
                context.Employees.Add(new Employee { Name = "Ева", Salary = 910, DepartmentId = 2 });
                context.Employees.Add(new Employee { Name = "София", Salary = 1050, DepartmentId = 3 });
                context.Employees.Add(new Employee { Name = "Егор", Salary = 1100, DepartmentId = 4 });
                context.Employees.Add(new Employee { Name = "Юрий", Salary = 1900, DepartmentId = 5 });
                context.Employees.Add(new Employee { Name = "Александр", Salary = 1600, DepartmentId = 1 });
                context.Employees.Add(new Employee { Name = "Дарья", Salary = 1850, DepartmentId = 2 });
                context.Employees.Add(new Employee { Name = "Елисей", Salary = 1900, DepartmentId = 3 });
                context.Employees.Add(new Employee { Name = "Иван", Salary = 2000, DepartmentId = 4 });
                context.Employees.Add(new Employee { Name = "Фёдор", Salary = 1250, DepartmentId = 5 });
                context.Employees.Add(new Employee { Name = "Даниил", Salary = 1000, DepartmentId = 1 });
                context.Employees.Add(new Employee { Name = "Мирослава", Salary = 1350, DepartmentId = 2 });
                context.Employees.Add(new Employee { Name = "Владимир", Salary = 1400, DepartmentId = 3 });
                context.Employees.Add(new Employee { Name = "Семён", Salary = 1000, DepartmentId = 4 });
                context.Employees.Add(new Employee { Name = "Анна", Salary = 1100, DepartmentId = 5 });
                context.Employees.Add(new Employee { Name = "Максим", Salary = 1950, DepartmentId = 1 });
                context.Employees.Add(new Employee { Name = "Маргарита", Salary = 1600, DepartmentId = 2 });
                context.Employees.Add(new Employee { Name = "Павел", Salary = 1250, DepartmentId = 3 });
                context.Employees.Add(new Employee { Name = "Георгий", Salary = 1300, DepartmentId = 4 });
                context.Employees.Add(new Employee { Name = "Майя", Salary = 1000, DepartmentId = 5 });
                context.SaveChanges();
            }
        }
    }
}
