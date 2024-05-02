﻿// <auto-generated />
using System;
using DatAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240502124239_OrderIdPropertyAddedToOrder")]
    partial class OrderIdPropertyAddedToOrder
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("AmountSold")
                        .HasColumnType("float");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("JoinDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Park Street",
                            AmountSold = 0.0,
                            Designation = "Manager",
                            Email = "haris@gmail.com",
                            JoinDate = new DateTime(2024, 5, 2, 18, 42, 38, 43, DateTimeKind.Local).AddTicks(3938),
                            Name = "Haris",
                            Salary = 3000m,
                            UserId = 4
                        },
                        new
                        {
                            Id = 2,
                            Address = "Dawson Street",
                            AmountSold = 0.0,
                            Designation = "Chef",
                            Email = "emad@gmail.com",
                            JoinDate = new DateTime(2024, 5, 2, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Emad",
                            Salary = 5000m,
                            UserId = 7
                        });
                });

            modelBuilder.Entity("Core.Models.EmployeeTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("TableId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("TableId");

                    b.ToTable("EmployeeTables");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmployeeId = 2,
                            TableId = 1
                        },
                        new
                        {
                            Id = 2,
                            EmployeeId = 1,
                            TableId = 2
                        });
                });

            modelBuilder.Entity("Core.Models.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("DiscountPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("DiscountType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Beef with spice",
                            Discount = 10m,
                            DiscountPrice = 12m,
                            DiscountType = "new yaer sale",
                            Name = "Kabab",
                            Price = 120m
                        },
                        new
                        {
                            Id = 2,
                            Description = "Chicken with veg",
                            Discount = 10m,
                            DiscountPrice = 11m,
                            DiscountType = "holiday season sale",
                            Name = "Butter Chicken",
                            Price = 110m
                        });
                });

            modelBuilder.Entity("Core.Models.FoodPackage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FoodId")
                        .HasColumnType("int");

                    b.Property<int>("PackageId")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("FoodId");

                    b.HasIndex("PackageId");

                    b.ToTable("FoodPackages");
                });

            modelBuilder.Entity("Core.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("FoodId")
                        .HasColumnType("int");

                    b.Property<int?>("FoodPackageId")
                        .HasColumnType("int");

                    b.Property<string>("OrderNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TableId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("TableId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Core.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("FoodId")
                        .HasColumnType("int");

                    b.Property<int?>("FoodPackageId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("FoodId");

                    b.HasIndex("FoodPackageId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("Core.Models.Package", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Packages");
                });

            modelBuilder.Entity("Core.Models.Table", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsOccupied")
                        .HasColumnType("bit");

                    b.Property<int>("NumberOfSeats")
                        .HasColumnType("int");

                    b.Property<string>("TableNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tables");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NumberOfSeats = 4,
                            TableNumber = "Table01"
                        },
                        new
                        {
                            Id = 2,
                            NumberOfSeats = 6,
                            TableNumber = "Table02"
                        });
                });

            modelBuilder.Entity("Core.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DobAddrerss")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExistingImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Facebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<string>("GenderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Github")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instagram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Linkedin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpouseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Twitter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            DobAddrerss = "Dhaka",
                            Email = "haris@gmail.com",
                            ExistingImage = "",
                            Facebook = "fb23",
                            FatherName = "Idris",
                            FirstName = "Mohammad",
                            GenderId = 0,
                            GenderName = "Male",
                            Github = "ggg",
                            Image = "",
                            Instagram = "Insta23",
                            Label = "12121",
                            LastName = "Rauf",
                            Linkedin = "link23",
                            MiddleName = "Haris",
                            MotherName = "Selina",
                            NId = 22244,
                            PhoneNumber = "98564545",
                            SpouseName = "Aysha",
                            Twitter = "twit23",
                            UserName = "HarisM"
                        },
                        new
                        {
                            Id = 7,
                            DobAddrerss = "Karachi",
                            Email = "emad@gmail.com",
                            ExistingImage = "",
                            Facebook = "fb41",
                            FatherName = "Abbas",
                            FirstName = "Mohammad",
                            GenderId = 0,
                            GenderName = "Male",
                            Github = "gg41",
                            Image = "",
                            Instagram = "Insta41",
                            Label = "244",
                            LastName = "Wasim",
                            Linkedin = "link41",
                            MiddleName = "Emad",
                            MotherName = "Raisa",
                            NId = 65234,
                            PhoneNumber = "567778",
                            SpouseName = "Mohoua",
                            Twitter = "twit41",
                            UserName = "EmadC"
                        });
                });

            modelBuilder.Entity("Core.Models.Employee", b =>
                {
                    b.HasOne("Core.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Core.Models.EmployeeTable", b =>
                {
                    b.HasOne("Core.Models.Employee", "Employee")
                        .WithMany("EmployeeTables")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Models.Table", "Table")
                        .WithMany("EmployeeTables")
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Table");
                });

            modelBuilder.Entity("Core.Models.FoodPackage", b =>
                {
                    b.HasOne("Core.Models.Food", "Food")
                        .WithMany("FoodPackages")
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Models.Package", "Package")
                        .WithMany("FoodPackages")
                        .HasForeignKey("PackageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Food");

                    b.Navigation("Package");
                });

            modelBuilder.Entity("Core.Models.Order", b =>
                {
                    b.HasOne("Core.Models.Table", "Table")
                        .WithMany("Orders")
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Table");
                });

            modelBuilder.Entity("Core.Models.OrderItem", b =>
                {
                    b.HasOne("Core.Models.Food", "Food")
                        .WithMany("OrderItems")
                        .HasForeignKey("FoodId");

                    b.HasOne("Core.Models.FoodPackage", "FoodPackage")
                        .WithMany("OrderItems")
                        .HasForeignKey("FoodPackageId");

                    b.HasOne("Core.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Food");

                    b.Navigation("FoodPackage");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Core.Models.Employee", b =>
                {
                    b.Navigation("EmployeeTables");
                });

            modelBuilder.Entity("Core.Models.Food", b =>
                {
                    b.Navigation("FoodPackages");

                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("Core.Models.FoodPackage", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("Core.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("Core.Models.Package", b =>
                {
                    b.Navigation("FoodPackages");
                });

            modelBuilder.Entity("Core.Models.Table", b =>
                {
                    b.Navigation("EmployeeTables");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
