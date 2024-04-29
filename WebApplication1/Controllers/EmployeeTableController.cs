﻿using Core.IRepository;
using Core.Models;
using Core.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeTableController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public EmployeeTableController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet("Get")]
        public IEnumerable<GetEmployeeTableRequest> Get()
        {
            List<Employee> employees = _unitOfWork.Employee.GetAll().ToList();
            List<EmployeeTable> employeeTables = _unitOfWork.EmployeeTable.GetAll().ToList();
            List<Table> tables = _unitOfWork.Table.GetAll().ToList();
            List<GetEmployeeTableRequest> employeeTableRequests = employeeTables.Select(u => new GetEmployeeTableRequest()
            {
                EmployeeTableId = u.Id,
                TableId = u.TableId,
                EmployeeId = u.Id
            }).ToList();

            return employeeTableRequests;
        }

        [HttpPost("Create")]
        public Task Create(CreateEmployeeTableRequest request)
        {
            
            EmployeeTable employeeTable = new EmployeeTable();
            employeeTable.TableId = request.TableId;
            employeeTable.EmployeeId = request.EmployeeId;
            _unitOfWork.EmployeeTable.Add(employeeTable);
            _unitOfWork.Save();
            return Task.CompletedTask;
        }


        [HttpPut("Update/{id}")]
        public Task Update(int id, UpdateEmployeeTableRequest request)
        {

            EmployeeTable employeeTable = _unitOfWork.EmployeeTable.Get(u => u.Id == id);
            Employee employee = _unitOfWork.Employee.Get(u => u.Id == employeeTable.EmployeeId);
            employeeTable.TableId = request.TableId;
            employeeTable.EmployeeId = request.EmployeeId; 
            _unitOfWork.EmployeeTable.Update(employeeTable);
            _unitOfWork.Save();
            return Task.CompletedTask;
        }

        [HttpDelete("Delete/{id}")]
        public Task Delete(int id, DeleteEmployeeRequest request)
        {
            EmployeeTable employeeTable = _unitOfWork.EmployeeTable.Get(u => u.Id == id);
            _unitOfWork.EmployeeTable.Remove(employeeTable);
            _unitOfWork.Save();
            return Task.CompletedTask;
        }



    }
}