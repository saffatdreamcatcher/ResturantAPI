using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModels
{
    public class GetAllEmployee
    {
        public int Id { get; set; }
        public string Designation { get; set; }
        public string JoinDate { get; set; }
        public decimal? AmountSold { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Image { get; set; } = string.Empty;
    }
}
