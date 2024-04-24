using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1.ViewModels;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)  git
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Haris",
                    Email = "haris@gmail.com",
                    Address = "Park Street",
                    JoinDate = DateTime.Now,
                    Salary = 3000,
                    Designation = "Manager",
                    UserId = 4
                    
                },

                new Employee
                {
                    Id = 2,
                    Name = "Emad",
                    Email = "emad@gmail.com",
                    Address = "Dawson Street",
                    JoinDate = DateTime.Today,
                    Salary = 5000,
                    Designation = "Chef",
                    UserId = 7
                }
    );

            modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 4,
                UserName = "HarisM",
                Email = "haris@gmail.com",
                PhoneNumber = "98564545",
                Label = "12121",
                FirstName = "Mohammad",
                MiddleName = "Haris",
                LastName = "Rauf",
                FatherName = "Idris",
                MotherName = "Selina",
                SpouseName = "Aysha",
                DobAddrerss = "Dhaka",
                NId = 22244,
                Image = "",
                ExistingImage = "",
                Facebook = "fb23",
                Linkedin = "link23",
                Twitter = "twit23",
                Instagram = "Insta23",
                Github = "ggg",
                GenderName = "Male",
            },
               new User
               {
                   Id = 7,
                   UserName = "EmadC",
                   Email = "emad@gmail.com",
                   PhoneNumber = "567778",
                   Label = "244",
                   FirstName = "Mohammad",
                   MiddleName = "Emad",
                   LastName = "Wasim",
                   FatherName = "Abbas",
                   MotherName = "Raisa",
                   SpouseName = "Mohoua",
                   DobAddrerss = "Karachi",
                   NId = 65234,
                   Image = "",
                   ExistingImage = "",
                   Facebook = "fb41",
                   Linkedin = "link41",
                   Twitter = "twit41",
                   Instagram = "Insta41",
                   Github = "gg41",
                   GenderName = "Male",
               }
            );
        }
    }
}
