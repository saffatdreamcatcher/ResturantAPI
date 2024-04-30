using Core.Models;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DatAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeTable> EmployeeTables { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<FoodPackage> FoodPackages { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
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

            modelBuilder.Entity<Table>().HasData(
           new Table
           {
               Id = 1,
               TableNumber = "Table01",
               NumberOfSeats = 4,
               

           },

           new Table
           {
               Id = 2,
               TableNumber = "Table02",
               NumberOfSeats = 6,
           }
);


            modelBuilder.Entity<EmployeeTable>().HasData(
          new EmployeeTable
          {
              Id = 1,
              EmployeeId = 2,
              TableId = 1

          },

          new EmployeeTable
          {
              Id = 2,
              EmployeeId = 1,
              TableId = 2
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
            modelBuilder.Entity<Food>().HasData(
          new Food
          {
              Id = 1,
              Name = "Kabab",
              Description = "Beef with spice",
              Price = 120,
              Discount = 10,
              DiscountPrice = 12,
              DiscountType = "new yaer sale"

          },

          new Food
          {
              Id = 2,
              Name = "Butter Chicken",
              Description = "Chicken with veg",
              Price = 110,
              Discount = 10,
              DiscountPrice = 11,
              DiscountType = "holiday season sale"
          }
);
        }
    }
}
