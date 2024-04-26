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
    public class EmployeeTableRepository : Repository<EmployeeTable>, IEmployeeTableRepository
    {
        private ApplicationDbContext _db;
        public EmployeeTableRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(EmployeeTable employeeTable)
        {
            _db.EmployeeTables.Update(employeeTable);
        }
    }
}
