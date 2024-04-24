﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240423142338_AddUserTableToDb")]
    partial class AddUserTableToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication1.Models.Employee", b =>
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
                            JoinDate = new DateTime(2024, 4, 23, 20, 23, 37, 232, DateTimeKind.Local).AddTicks(1344),
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
                            JoinDate = new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Emad",
                            Salary = 5000m,
                            UserId = 7
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.User", b =>
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
                        .IsRequired()
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instagram")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Linkedin")
                        .IsRequired()
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
                        .IsRequired()
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

            modelBuilder.Entity("WebApplication1.Models.Employee", b =>
                {
                    b.HasOne("WebApplication1.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
