using System.ComponentModel.DataAnnotations;

namespace Core.ViewModels
{
    public class CreateStudentRequest
    {
        [Required]
        [MinLength(10)]
        public string Name { get; set; }
    }
}
