using Core.DataAccess.Repository.IRepository;
using Core.Models;
using Core.ViewModels;
using DatAccess.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Repository
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        private ApplicationDbContext _db;
        public EmployeeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(Employee employee)
        {
            _db.Employees.Update(employee);
        }
    }
}
