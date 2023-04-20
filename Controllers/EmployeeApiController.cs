using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeApiController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>()
        {
            new Employee()
            {
                Id = 1,
                Name = "John Wick",
                Department = "IT",
                Email = "John@wick.com",
                Class = EmpClass.Day
            },
            new Employee()
            {
                Id = 2,
                Name = "Tushar",
                Department = "IT",
                Email = "tushar@gmail.com",
                Class = EmpClass.Day
            },
        };


        [HttpGet("all")]
        public ActionResult<List<Employee>> Get()
        {
            return Ok(employees);
        }

        [HttpGet("{id}")]

        public ActionResult<Employee> Get(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        // [HttpGet]
        // public ActionResult<List<Employee>> GetSingle()
        // {
        //     return Ok(employees[0]);
        // }

        [HttpPost]
        public ActionResult<List<Employee>> AddEmp(Employee emp)
        {
            employees.Add(emp);
            return Ok(employees);
        }

        [HttpPut]
        public ActionResult<List<Employee>> UpdateEmp(Employee emp)
        {
            var employee = employees.FirstOrDefault(e => e.Id == emp.Id);
            if (employee == null)
            {
                return NotFound();
            }

            employee.Name = emp.Name;
            employee.Department = emp.Department;
            employee.Email = emp.Email;
            employee.Class = emp.Class;

            return Ok(employees);
        }

        [HttpDelete("{id}")]
        public ActionResult<List<Employee>> DeleteEmp(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            employees.Remove(employee);
            return Ok(employees);
        }
            
    }
}