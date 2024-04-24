using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication1.ViewModels;

namespace WebApplication1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime? JoinDate { get; set; }
        public decimal Salary { get; set; }

        public string Designation { get; set; }
        public double AmountSold { get; set; } = 0;
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; } 
    }
}
