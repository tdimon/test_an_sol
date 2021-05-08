using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using WebAPIApp.Models;
using System.Threading.Tasks;

namespace WebAPIApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        MainContext db;
        public EmployeesController(MainContext context)
        {
            db = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> Get()
        {
            IQueryable<Employee> employees = db.Employees;
            employees = employees.Join(db.Departments, e => e.DepartmentId, d => d.Id, (e, d) => new Employee{
                Id = e.Id,
                Name = e.Name,
                Salary = e.Salary,
                DepartmentId = e.DepartmentId,
                Department = d
            });
            return await employees.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> Get(int id)
        {
            Employee employee = await db.Employees.FirstOrDefaultAsync(x => x.Id == id);
            if (employee == null)
                return NotFound();
            return new ObjectResult(employee);
        }

        [HttpPost]
        public async Task<ActionResult<Employee>> Post(Employee employee)
        {
            if (employee == null)
            {
                return BadRequest();
            }

            db.Employees.Add(employee);
            await db.SaveChangesAsync();
            return Ok(employee);
        }

        [HttpPut]
        public async Task<ActionResult<Employee>> Put(Employee employee)
        {
            if (employee == null)
            {
                return BadRequest();
            }
            if (!db.Employees.Any(x => x.Id == employee.Id))
            {
                return NotFound();
            }

            db.Update(employee);
            await db.SaveChangesAsync();
            return Ok(employee);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Employee>> Delete(int id)
        {
            Employee employee = db.Employees.FirstOrDefault(x => x.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            db.Employees.Remove(employee);
            await db.SaveChangesAsync();
            return Ok(employee);
        }
    }
}