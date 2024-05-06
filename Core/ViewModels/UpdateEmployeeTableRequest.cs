using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Core.ViewModels
{
    public class UpdateEmployeeTableRequest
    {
        public Guid EmployeeId { get; set; }
        public int TableId { get; set; }
    }
}
