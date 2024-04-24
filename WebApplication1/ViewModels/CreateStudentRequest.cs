using System.ComponentModel.DataAnnotations;

namespace WebApplication1.ViewModels
{
    public class CreateStudentRequest
    {
        [Required]
        [MinLength(10)]
        public string Name { get; set; }
    }
}
