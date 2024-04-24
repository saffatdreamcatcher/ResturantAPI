using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.ViewModels;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public int EmployeeId { get; private set; }

        public EmployeeController(ApplicationDbContext db)
        {
            _db = db;
        }


        [HttpGet("Get")]
        public IEnumerable<GetEmployeeRequest> Get()
        {
            List<Employee> employees = _db.Employees.ToList();
            List<GetEmployeeRequest> employeeRequests = employees.Select(u => new GetEmployeeRequest()
            {
                EmployeeId = u.Id,
                Name = u.Name
            }).ToList();

            return employeeRequests;
        }



        [HttpGet("Get/{Id}")]
        public EmployeeResource Get(int Id)
         {
            
            Employee? employee = _db.Employees.Find(Id);
            EmployeeResource employeeResource = new EmployeeResource();
            employeeResource.Id = Id;
            employeeResource.JoinDate = employee.JoinDate != null ? (DateTime)employee.JoinDate : DateTime.MinValue;
            employeeResource.Designation = employee.Designation;
            employeeResource.AmountSold = employee.AmountSold;
            User? user = _db.Users.Find(employee.UserId);
            UserResource userResource = new UserResource();
            userResource.FirstName = user.FirstName;
            userResource.Email = user.Email; 
            userResource.PhoneNumber = user.PhoneNumber;
            employeeResource.UserResource = userResource;
            return employeeResource;

        }

        [HttpGet("non-assigned-employees/{tableId}")]
        public IEnumerable<NonAssignedEmployee> NonAssignedEmployees(int tableId)
        {
            return Enumerable.Empty<NonAssignedEmployee>();
        }

        [HttpPost("Create")]
        public Task Create(CreateEmployeeRequest request)
        {
            return Task.CompletedTask;
        }
        [HttpPut("Update/{id}")]
        public Task Update(UpdateEmployeeRequest id)
        {
            return Task.CompletedTask;
        }
        [HttpDelete("Delete/{id}")]
        public Task Delete(DeleteEmployeeRequest id)
        {
            return Task.CompletedTask;
        }
    }
}
