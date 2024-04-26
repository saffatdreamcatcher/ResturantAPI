using Core.Models;
using Core.Repository.IRepository;
using Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Repository.IRepository
{
    public interface IEmployeeTableRepository : IRepository<EmployeeTable>
    {
        void Update(EmployeeTable employeeTable);

    }
}
