using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DatAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, Role , Guid>
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
                    Id = new Guid("1e483d73-6cfe-43f1-a317-5a97412228eb"),
                    Name = "Haris",
                    Email = "haris@gmail.com",
                    Address = "Park Street",
                    JoinDate = DateTime.Now,
                    Salary = 3000,
                    Designation = "Manager",
                    UserId = new Guid("16639bb0-4a6e-4e5a-ad05-560d4025d8de")
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
               });


            modelBuilder.Entity<EmployeeTable>().HasData(
          new EmployeeTable
          {
              Id = 1,
              EmployeeId = new Guid("1e483d73-6cfe-43f1-a317-5a97412228eb"),
              TableId = 1

          }

         
);

            modelBuilder.Entity<User>().HasData(

                new User()
                {
                    Id = new Guid("16639bb0-4a6e-4e5a-ad05-560d4025d8de"),
                    FirstName = "System",
                    MiddleName = "Admin",
                    LastName = "",
                    FatherName = "N/A",
                    MotherName = "N/A",
                    SpouseName = "N/A",
                    Label = "12121",
                    NId = 645322,
                    DobAddrerss = "Karachi",
                    Image = "",
                    ExistingImage = "",
                    Facebook = "fb41",
                    Linkedin = "link41",
                    Twitter = "twit41",
                    Instagram = "Insta41",
                    Github = "gg41",
                    GenderName = "Male",
                    UserName = "admin@mail.com",
                    NormalizedUserName = "admin@mail.com",
                    Email = "admin@mail.com",
                    NormalizedEmail = "admin@mail.com",
                    EmailConfirmed = false,
                    PasswordHash = "AQAAAAEAACcQAAAAEFTw0YzFmNSap0Oq8Tb4C2h1Jdvd1fMHL+pKDwaxcY+2Rg/i3jP0cAKJshnm6wy/fQ==",
                    SecurityStamp = "KOFABGFNZCSAIOQ7VCPER53GEIMMBIFK",
                    ConcurrencyStamp = "c0546a67-12e3-413e-98d7-2e981f03aa95",
                    PhoneNumber = "01779866803",
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,


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
