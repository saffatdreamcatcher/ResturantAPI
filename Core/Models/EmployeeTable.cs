using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class EmployeeTable
    {
        public int Id { get; set; }
        public Guid EmployeeId { get; set; }
        
        public int TableId { get; set; }
        
        public Employee Employee { get; set; }
        public Table Table { get; set; }
    }
}
