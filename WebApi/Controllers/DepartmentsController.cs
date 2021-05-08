using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using WebAPIApp.Models;
using System.Threading.Tasks;
using System;

namespace WebAPIApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepartmentsController : ControllerBase
    {
        MainContext db;
        public DepartmentsController(MainContext context)
        {
            db = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Department>>> Get()
        {
            return await db.Departments.ToListAsync();
        }

        [HttpGet("getfull")]
        public async Task<ActionResult<IEnumerable<dynamic>>> GetFull()
        {
            var result = db.Employees.GroupBy(d => d.DepartmentId)
                .Select(res => new { Id = res.Key, Count = res.Count(), Summ = res.Sum(e => e.Salary) })
                .Join(db.Departments, main => main.Id, d => d.Id, (main, d) => new 
                {
                    Id = main.Id,
                    Name = d.Name,
                    Count = main.Count,
                    Summ = main.Summ
                });
            return await result.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Department>> Get(int id)
        {
            Department department = await db.Departments.FirstOrDefaultAsync(x => x.Id == id);
            if (department == null)
                return NotFound();
            return new ObjectResult(department);
        }

        [HttpPost]
        public async Task<ActionResult<Department>> Post(Department department)
        {
            if (department == null)
            {
                return BadRequest();
            }

            db.Departments.Add(department);
            await db.SaveChangesAsync();
            return Ok(department);
        }

        [HttpPut]
        public async Task<ActionResult<Department>> Put(Department department)
        {
            if (department == null)
            {
                return BadRequest();
            }
            if (!db.Departments.Any(x => x.Id == department.Id))
            {
                return NotFound();
            }

            db.Update(department);
            await db.SaveChangesAsync();
            return Ok(department);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Department>> Delete(int id)
        {
            Department department = db.Departments.FirstOrDefault(x => x.Id == id);
            if (department == null)
            {
                return NotFound();
            }
            db.Departments.Remove(department);
            await db.SaveChangesAsync();
            return Ok(department);
        }
    }
}