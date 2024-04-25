using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Core.ViewModels
{
    public class UpdateEmployeeRequest
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Designation { get; set; }
    }
}
