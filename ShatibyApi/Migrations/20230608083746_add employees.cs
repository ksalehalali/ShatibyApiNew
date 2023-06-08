using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShatibyApi.Migrations
{
    /// <inheritdoc />
    public partial class addemployees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("25cf62ef-6f8b-45d9-aedf-2b9ca2ad28f9"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("8213f109-38a8-455e-9edf-4e6632cbeb0f"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("931b1ee5-fefd-45f4-b5cc-3643f01db691"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("98a6fa48-5261-49a6-a3b3-08d582c598b8"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("b1b391f2-6386-4068-a7ec-ce55976cfbd7"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("b4084c2e-d74c-44ce-a12a-9fb92f0d8e71"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("c3d9e583-318a-4a9b-90c7-41b6a1e15109"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("e17bebe4-9721-44db-85e3-a0e59d318c1c"));

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name_EN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name_AR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ege = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JoinDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<double>(type: "float", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "employeeSalaries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employeeSalaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_employeeSalaries_employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "years",
                columns: new[] { "Id", "Name_AR", "Name_EN", "Order_of_theyear" },
                values: new object[,]
                {
                    { new Guid("012725fd-b4a5-4cbe-b639-556fbfb445c6"), "السنة الاولى", "First year", 1 },
                    { new Guid("5b1133b6-aaf3-40b5-89e1-68e9a6c9c552"), "السنة الرابعة", "Fourth year", 4 },
                    { new Guid("600bb29b-46c3-4b1e-81ed-525f0715024d"), "السنة السادسة", "Sixth year", 6 },
                    { new Guid("649ad43e-ec22-424f-a98b-a39405f93f78"), "السنة الثامنة", "Eighth year", 8 },
                    { new Guid("9ab1e9f8-0738-498d-aba9-1a82033a0ef2"), "السنة الثالثة", "Third year", 3 },
                    { new Guid("a1b7e588-b857-4b76-9045-77daf52622a6"), "السنة السابعة", "Seventh year", 7 },
                    { new Guid("d37648a8-bfa8-4aae-aedb-830e0b42fe3e"), "السنة االثانية", "Second year", 2 },
                    { new Guid("fc9c21e6-2784-4dee-aa53-002f11763cc9"), "السنة الخامسة", "Fifth year", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_employeeSalaries_EmployeeId",
                table: "employeeSalaries",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employeeSalaries");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("012725fd-b4a5-4cbe-b639-556fbfb445c6"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("5b1133b6-aaf3-40b5-89e1-68e9a6c9c552"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("600bb29b-46c3-4b1e-81ed-525f0715024d"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("649ad43e-ec22-424f-a98b-a39405f93f78"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("9ab1e9f8-0738-498d-aba9-1a82033a0ef2"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("a1b7e588-b857-4b76-9045-77daf52622a6"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("d37648a8-bfa8-4aae-aedb-830e0b42fe3e"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("fc9c21e6-2784-4dee-aa53-002f11763cc9"));

            migrationBuilder.InsertData(
                table: "years",
                columns: new[] { "Id", "Name_AR", "Name_EN", "Order_of_theyear" },
                values: new object[,]
                {
                    { new Guid("25cf62ef-6f8b-45d9-aedf-2b9ca2ad28f9"), "السنة الاولى", "First year", 1 },
                    { new Guid("8213f109-38a8-455e-9edf-4e6632cbeb0f"), "السنة الرابعة", "Fourth year", 4 },
                    { new Guid("931b1ee5-fefd-45f4-b5cc-3643f01db691"), "السنة السادسة", "Sixth year", 6 },
                    { new Guid("98a6fa48-5261-49a6-a3b3-08d582c598b8"), "السنة الثالثة", "Third year", 3 },
                    { new Guid("b1b391f2-6386-4068-a7ec-ce55976cfbd7"), "السنة السابعة", "Seventh year", 7 },
                    { new Guid("b4084c2e-d74c-44ce-a12a-9fb92f0d8e71"), "السنة االثانية", "Second year", 2 },
                    { new Guid("c3d9e583-318a-4a9b-90c7-41b6a1e15109"), "السنة الخامسة", "Fifth year", 5 },
                    { new Guid("e17bebe4-9721-44db-85e3-a0e59d318c1c"), "السنة الثامنة", "Eighth year", 8 }
                });
        }
    }
}
