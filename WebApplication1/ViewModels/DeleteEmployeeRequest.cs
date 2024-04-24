using NSwag.Annotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebApplication1.ViewModels
{
    public class DeleteEmployeeRequest
    {
        [Required]
        [JsonIgnore]
        public int Id { get; set; }
    }
}
