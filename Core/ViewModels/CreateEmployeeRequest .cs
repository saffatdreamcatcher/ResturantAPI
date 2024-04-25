using System.ComponentModel.DataAnnotations;

namespace Core.ViewModels
{
    public class CreateEmployeeRequest
    {
        public string Designation { get; set; }
        public DateTime JoinDate { get; set; }
        public int Email { get; set; }
        public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string SpouseName { get; set; }
        public string Dob { get; set; }
        public int NId { get; set; }
        public string GenderName { get; set; }

        public string Image { get; set; }
        public string Base64 { get; set; }
    }
}
