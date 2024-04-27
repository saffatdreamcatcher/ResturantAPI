using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModels
{
    public class EmployeeTableResource
    {
        public int Id { get; set; }
        public Employee Employee { get; set; }
        public Table Table { get; set; }
        public TableResource TableResource { get; set; }
        public EmployeeResource EmployeeResource { get; set; }

    }
}
