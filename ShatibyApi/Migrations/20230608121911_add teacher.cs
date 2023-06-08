using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShatibyApi.Migrations
{
    /// <inheritdoc />
    public partial class addteacher : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "semesters",
                keyColumn: "Id",
                keyValue: new Guid("9449f67c-eeb5-4ee3-89ad-1549dbf36ae3"));

            migrationBuilder.DeleteData(
                table: "semesters",
                keyColumn: "Id",
                keyValue: new Guid("b675f74a-db83-41f4-85ff-1288cf14f166"));

            migrationBuilder.DeleteData(
                table: "semesters",
                keyColumn: "Id",
                keyValue: new Guid("bfd72a69-8486-4179-a5ba-6b0a68c5963d"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("2c2d2d72-6939-4043-85fa-c5ad9e2227bc"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("607ceebc-22f7-444a-8b92-dc82d7126d01"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("81f8b8b0-87e9-4e6f-bc64-43d36644b73d"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("bf8f145a-5a7a-4534-ba77-22d01b0cf63c"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("c173edc3-a764-47d3-9662-cc898ed7531d"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("c719461d-1421-49c7-b2c0-5b176e8950a6"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("d3164a78-a73e-4546-9b2a-dece4f2f46eb"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("d4c66d12-4d23-4eb2-bc33-3624f30d2f57"));

            migrationBuilder.CreateTable(
                name: "teachers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name_AR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ege = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rigestered = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PartsSaved = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<double>(type: "float", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "teacherSalaries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teacherSalaries", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "semesters",
                columns: new[] { "Id", "Name_AR", "Name_EN" },
                values: new object[,]
                {
                    { new Guid("5e3256c1-30f4-46aa-b444-9ace7b766d87"), "الفصل الاول", "Second Semester" },
                    { new Guid("76d62f62-00d9-4d6b-88fe-9293996f2032"), "الفصل التكميلي", "Supplementary semester" },
                    { new Guid("8c94be14-32a3-4c43-8cf3-ac36676762ee"), "الفصل الاول", "First Semester" }
                });

            migrationBuilder.InsertData(
                table: "years",
                columns: new[] { "Id", "Name_AR", "Name_EN", "Order_of_theyear" },
                values: new object[,]
                {
                    { new Guid("2f15bc36-b67f-4488-a500-23fbffd7c82d"), "السنة الخامسة", "Fifth year", 5 },
                    { new Guid("37654b1f-3b18-44ac-8232-1fa1361dd119"), "السنة الاولى", "First year", 1 },
                    { new Guid("459937ff-7ebd-4554-9f49-7aaa7f3ace46"), "السنة االثانية", "Second year", 2 },
                    { new Guid("5fe6136d-cbdf-496f-8e7b-9f69e6664200"), "السنة الثالثة", "Third year", 3 },
                    { new Guid("7ebbef8a-03e1-42d4-917c-1339b1c96e87"), "السنة السادسة", "Sixth year", 6 },
                    { new Guid("9abd632b-c84f-4492-a09a-76de6c41abe8"), "السنة الرابعة", "Fourth year", 4 },
                    { new Guid("d2a25faa-f1a0-4698-97d4-59251a0c457b"), "السنة السابعة", "Seventh year", 7 },
                    { new Guid("e7e0aa66-342d-494a-ac6f-6af85d2678d5"), "السنة الثامنة", "Eighth year", 8 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "teachers");

            migrationBuilder.DropTable(
                name: "teacherSalaries");

            migrationBuilder.DeleteData(
                table: "semesters",
                keyColumn: "Id",
                keyValue: new Guid("5e3256c1-30f4-46aa-b444-9ace7b766d87"));

            migrationBuilder.DeleteData(
                table: "semesters",
                keyColumn: "Id",
                keyValue: new Guid("76d62f62-00d9-4d6b-88fe-9293996f2032"));

            migrationBuilder.DeleteData(
                table: "semesters",
                keyColumn: "Id",
                keyValue: new Guid("8c94be14-32a3-4c43-8cf3-ac36676762ee"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("2f15bc36-b67f-4488-a500-23fbffd7c82d"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("37654b1f-3b18-44ac-8232-1fa1361dd119"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("459937ff-7ebd-4554-9f49-7aaa7f3ace46"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("5fe6136d-cbdf-496f-8e7b-9f69e6664200"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("7ebbef8a-03e1-42d4-917c-1339b1c96e87"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("9abd632b-c84f-4492-a09a-76de6c41abe8"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("d2a25faa-f1a0-4698-97d4-59251a0c457b"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("e7e0aa66-342d-494a-ac6f-6af85d2678d5"));

            migrationBuilder.InsertData(
                table: "semesters",
                columns: new[] { "Id", "Name_AR", "Name_EN" },
                values: new object[,]
                {
                    { new Guid("9449f67c-eeb5-4ee3-89ad-1549dbf36ae3"), "الفصل الاول", "First Semester" },
                    { new Guid("b675f74a-db83-41f4-85ff-1288cf14f166"), "الفصل الاول", "Second Semester" },
                    { new Guid("bfd72a69-8486-4179-a5ba-6b0a68c5963d"), "الفصل التكميلي", "Supplementary semester" }
                });

            migrationBuilder.InsertData(
                table: "years",
                columns: new[] { "Id", "Name_AR", "Name_EN", "Order_of_theyear" },
                values: new object[,]
                {
                    { new Guid("2c2d2d72-6939-4043-85fa-c5ad9e2227bc"), "السنة الخامسة", "Fifth year", 5 },
                    { new Guid("607ceebc-22f7-444a-8b92-dc82d7126d01"), "السنة االثانية", "Second year", 2 },
                    { new Guid("81f8b8b0-87e9-4e6f-bc64-43d36644b73d"), "السنة السادسة", "Sixth year", 6 },
                    { new Guid("bf8f145a-5a7a-4534-ba77-22d01b0cf63c"), "السنة الاولى", "First year", 1 },
                    { new Guid("c173edc3-a764-47d3-9662-cc898ed7531d"), "السنة الرابعة", "Fourth year", 4 },
                    { new Guid("c719461d-1421-49c7-b2c0-5b176e8950a6"), "السنة الثالثة", "Third year", 3 },
                    { new Guid("d3164a78-a73e-4546-9b2a-dece4f2f46eb"), "السنة الثامنة", "Eighth year", 8 },
                    { new Guid("d4c66d12-4d23-4eb2-bc33-3624f30d2f57"), "السنة السابعة", "Seventh year", 7 }
                });
        }
    }
}
