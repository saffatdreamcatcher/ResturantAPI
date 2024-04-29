using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Core.ViewModels
{
    public class GetEmployeeTableRequest
    {
        [JsonIgnore]
        public int Id { get; set; }
        public int EmployeeId { get; set; }

        public int TableId { get; set; }

    }
}
