using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModels
{
    public class GetEmployeeTableRequest
    {
        public int Id { get; set; }
        public EmployeeOptionResource Employee { get; set; }
        public TableOptionResource Table { get; set; }
        
    }
}
