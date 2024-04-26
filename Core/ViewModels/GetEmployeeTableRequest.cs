using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModels
{
    public class GetEmployeeTableRequest
    {
        public int EmployeeTableId { get; set; }
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int TableId { get; set; }
        public string TableNumber { get; set; }
    }
}
