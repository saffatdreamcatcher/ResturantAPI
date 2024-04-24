using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebApplication1.ViewModels
{
    public class UpdateEmployeeRequest
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Designation { get; set; }
    }
}
