using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModels
{
    public class CUTableRequest
    {
        public int Id { get; set; } 
        public string TableNumber { get; set; }
        public int NumberOfSeats { get; set; }
        public string? Image { get; set; }
    }
}
