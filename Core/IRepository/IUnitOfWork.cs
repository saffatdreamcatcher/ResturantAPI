using Core.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.IRepository
{
    public interface IUnitOfWork
    {
        IEmployeeRepository Employee { get; }
        IEmployeeTableRepository EmployeeTable { get; }
        ITableRepository Table { get; }
        IUserRepository User { get; }
        void Save();
    }
}
