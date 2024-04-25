using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Core.ViewModels
{
    public class DeleteEmployeeRequest
    {
        [Required]
        [JsonIgnore]
        public int Id { get; set; }
    }
}
