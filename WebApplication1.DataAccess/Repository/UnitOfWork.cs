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
        public IFoodPackageRepository FoodPackage { get; private set; }
        public IPackageRepository Package { get; private set; }
        public IOrderRepository Order { get; private set; }
        public IOrderItemRepository OrderItem { get; private set; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Employee = new EmployeeRepository(_db);
            EmployeeTable = new EmployeeTableRepository(_db);
            Table = new TableRepository(_db);
            User = new UserRepository(_db);
            Food = new FoodRepository(_db);
            Order = new OrderRepository(_db);
            OrderItem = new OrderItemRepository(_db);
            FoodPackage = new FoodPackageRepository(_db);
            Package = new PackageRepository(_db); 

        }
       

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
