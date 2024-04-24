using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.ViewModels
{
    public class NonAssignedEmployee
    {
        [Required]
        [NotMapped]
        public int TableId { get; set; }
        public int EmployeeID { get; set; }
        public string Name { get; set; }
    }
}
