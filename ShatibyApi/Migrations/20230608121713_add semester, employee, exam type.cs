using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShatibyApi.Migrations
{
    /// <inheritdoc />
    public partial class addsemesteremployeeexamtype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employeeSalaries_employees_EmployeeId",
                table: "employeeSalaries");

            migrationBuilder.DropForeignKey(
                name: "FK_students_levels_LevelId",
                table: "students");

            migrationBuilder.DropForeignKey(
                name: "FK_students_years_YearId",
                table: "students");

            migrationBuilder.DropTable(
                name: "teachers");

            migrationBuilder.DropIndex(
                name: "IX_students_LevelId",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_YearId",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_employeeSalaries_EmployeeId",
                table: "employeeSalaries");

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("059819c8-6d37-414e-b481-4617a42d16b4"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("1d47fa2b-ccd9-405a-b373-17a9545ad6f9"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("35478ccb-f707-423c-83f0-6eea98e59f8e"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("4006a766-0284-4b4b-9b71-f8e906ab5ca9"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("7ad0d35a-b0bc-4470-a63a-79b57ed2bc80"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("9ecafc8d-3f64-4427-aa97-3959c6d44f77"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("f51df39a-9a23-4d5f-b3dd-5cfbff96c89e"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("f9cccb33-e2ba-425a-9566-8e9da92cf332"));

            migrationBuilder.DropColumn(
                name: "LevelId",
                table: "students");

            migrationBuilder.DropColumn(
                name: "YearId",
                table: "students");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "employeeSalaries");

            migrationBuilder.CreateTable(
                name: "grades",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Degree = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_grades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "studentExams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentExams", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "grades");

            migrationBuilder.DropTable(
                name: "studentExams");

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

            migrationBuilder.AddColumn<Guid>(
                name: "LevelId",
                table: "students",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "YearId",
                table: "students",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "EmployeeId",
                table: "employeeSalaries",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "teachers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LevelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ege = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name_AR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PartsSaved = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rigestered = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Salary = table.Column<double>(type: "float", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_teachers_levels_LevelId",
                        column: x => x.LevelId,
                        principalTable: "levels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "years",
                columns: new[] { "Id", "Name_AR", "Name_EN", "Order_of_theyear" },
                values: new object[,]
                {
                    { new Guid("059819c8-6d37-414e-b481-4617a42d16b4"), "السنة السادسة", "Sixth year", 6 },
                    { new Guid("1d47fa2b-ccd9-405a-b373-17a9545ad6f9"), "السنة الرابعة", "Fourth year", 4 },
                    { new Guid("35478ccb-f707-423c-83f0-6eea98e59f8e"), "السنة الثامنة", "Eighth year", 8 },
                    { new Guid("4006a766-0284-4b4b-9b71-f8e906ab5ca9"), "السنة الاولى", "First year", 1 },
                    { new Guid("7ad0d35a-b0bc-4470-a63a-79b57ed2bc80"), "السنة االثانية", "Second year", 2 },
                    { new Guid("9ecafc8d-3f64-4427-aa97-3959c6d44f77"), "السنة الثالثة", "Third year", 3 },
                    { new Guid("f51df39a-9a23-4d5f-b3dd-5cfbff96c89e"), "السنة السابعة", "Seventh year", 7 },
                    { new Guid("f9cccb33-e2ba-425a-9566-8e9da92cf332"), "السنة الخامسة", "Fifth year", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_students_LevelId",
                table: "students",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_students_YearId",
                table: "students",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_employeeSalaries_EmployeeId",
                table: "employeeSalaries",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_teachers_LevelId",
                table: "teachers",
                column: "LevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_employeeSalaries_employees_EmployeeId",
                table: "employeeSalaries",
                column: "EmployeeId",
                principalTable: "employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_students_levels_LevelId",
                table: "students",
                column: "LevelId",
                principalTable: "levels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_students_years_YearId",
                table: "students",
                column: "YearId",
                principalTable: "years",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
