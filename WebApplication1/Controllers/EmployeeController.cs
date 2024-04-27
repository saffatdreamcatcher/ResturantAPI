using Azure.Core;
using Core.DataAccess.Repository.IRepository;
using Core.IRepository;
using Core.Models;
using Core.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;


        //public int EmployeeId { get; private set; }

        public EmployeeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }


        [HttpGet("Get")]
        public IEnumerable<GetEmployeeRequest> Get()
        {
            List<Employee> employees = _unitOfWork.Employee.GetAll().ToList();
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

            Employee? employee = _unitOfWork.Employee.Get(u => u.Id == Id);
            EmployeeResource employeeResource = new EmployeeResource();
            employeeResource.Id = Id;
            employeeResource.JoinDate = employee.JoinDate != null ? (DateTime)employee.JoinDate : DateTime.MinValue;
            employeeResource.Designation = employee.Designation;
            employeeResource.AmountSold = employee.AmountSold;
            User? user = _unitOfWork.User.Get(u => u.Id == employee.UserId);
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

            User user = new User();
            user.FirstName = request.FirstName;
            user.MotherName = request.MotherName;
            user.LastName = request.LastName;
            user.FatherName = request.FatherName;
            user.SpouseName = request.SpouseName;
            user.NId = request.NId;
            user.GenderName = request.GenderName;
            user.PhoneNumber = request.PhoneNumber;
            user.DobAddrerss = request.DobAddrerss;
            user.Email = request.Email;
            user.Label = "sssssss";
            user.UserName = "hhhhhhhh";
            user.SpouseName = "";
            user.MiddleName = request.MiddleName;
            Employee employee = new Employee();
            employee.User = user;
            employee.JoinDate = request.JoinDate;
            employee.Email = request.Email;
            employee.Designation = request.Designation;
            employee.Salary = 0;
            employee.Address = "downtown abbey";
            employee.Name = "Jason";

            _unitOfWork.Employee.Add(employee);
            _unitOfWork.Save();
            return Task.CompletedTask;
        }


        [HttpPut("Update/{id}")]
        public  Task Update(int id, UpdateEmployeeRequest request)
        {

            Employee? employee =   _unitOfWork.Employee.Get(u => u.Id == id);
            if (employee == null) 
            {
                throw new Exception("Employee not found");
            }
            employee.Designation = request.Designation;
            _unitOfWork.Employee.Update(employee);
            _unitOfWork.Save(); 
            return Task.CompletedTask;
        }



        [HttpDelete("Delete/{id}")]
        public Task Delete(int id, DeleteEmployeeRequest request)
        {
            Employee? employee = _unitOfWork.Employee.Get(u => u.Id == id);
            _unitOfWork.Employee.Remove(employee);
            _unitOfWork.Save();
            return Task.CompletedTask;
        }
    }
}
