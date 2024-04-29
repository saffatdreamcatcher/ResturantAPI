using Core.DataAccess.Repository.IRepository;
using Core.IRepository;
using Core.Models;
using DatAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public IEmployeeRepository Employee { get; private set; }
        public IEmployeeTableRepository EmployeeTable { get; private set; }
        public ITableRepository Table { get; private set; }
        public IUserRepository User { get; private set; }
        public IFoodRepository Food { get; private set; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Employee = new EmployeeRepository(_db);
            EmployeeTable = new EmployeeTableRepository(_db);
            Table = new TableRepository(_db);
            User = new UserRepository(_db);
            Food = new FoodRepository(_db);
        }
       

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
