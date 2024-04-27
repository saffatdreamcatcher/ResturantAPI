using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Core.ViewModels
{
    public class UpdateEmployeeTableRequest
    {
        public int EmployeeId { get; set; }
        public int TableId { get; set; }
    }
}
