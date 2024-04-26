using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployeeTableAndTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfSeats = table.Column<int>(type: "int", nullable: false),
                    IsOccupied = table.Column<bool>(type: "bit", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    TableId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeTables_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeTables_Tables_TableId",
                        column: x => x.TableId,
                        principalTable: "Tables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "JoinDate",
                value: new DateTime(2024, 4, 26, 16, 21, 19, 460, DateTimeKind.Local).AddTicks(3582));

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "Image", "IsOccupied", "NumberOfSeats", "TableNumber" },
                values: new object[,]
                {
                    { 1, null, null, 4, "Table01" },
                    { 2, null, null, 6, "Table02" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeTables",
                columns: new[] { "Id", "EmployeeId", "TableId" },
                values: new object[,]
                {
                    { 1, 2, 1 },
                    { 2, 1, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTables_EmployeeId",
                table: "EmployeeTables",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTables_TableId",
                table: "EmployeeTables",
                column: "TableId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeTables");

            migrationBuilder.DropTable(
                name: "Tables");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "JoinDate",
                value: new DateTime(2024, 4, 26, 12, 31, 18, 921, DateTimeKind.Local).AddTicks(2620));
        }
    }
}
