﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Table
    {
        public int Id { get; set; }
        public string TableNumber { get; set; }
        public int NumberOfSeats { get; set; }
        public bool? IsOccupied { get; set; }
        public string? Image { get; set; }

        public virtual ICollection<EmployeeTable> EmployeeTables { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

    }
}
