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
        //private readonly IUserRepository _userRepo;


        public int EmployeeId { get; private set; }

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


        //[HttpPost("Create")]
        //public Task Create(CreateEmployeeRequest request)
        //{
        //    //Employee? employee = _unitOfWork.Employee.Get(u => u.Id == EmployeeId);
        //    User? user = _unitOfWork.User.Get(u => u.Id == u.Id);
        //    CreateEmployeeRequest createEmployeeRequest = new()
        //    {

        //        //Designation = request.Designation
        //        FirstName = request.FirstName,
        //        LastName = request.LastName


        //    };
        //    _unitOfWork.Employee.Add(request);
        //    _unitOfWork.Save();
        //    return Task.CompletedTask;
        //}

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
