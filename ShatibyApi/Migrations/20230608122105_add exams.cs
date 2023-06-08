using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShatibyApi.Migrations
{
    /// <inheritdoc />
    public partial class addexams : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "exams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "lessons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lessons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "lessonTimes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Day = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lessonTimes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "semesters",
                columns: new[] { "Id", "Name_AR", "Name_EN" },
                values: new object[,]
                {
                    { new Guid("5ff3b284-71eb-4602-b504-fdb7bcb2fb64"), "الفصل الاول", "First Semester" },
                    { new Guid("b64a7958-ef75-4802-bf5f-c53a7c55b818"), "الفصل التكميلي", "Supplementary semester" },
                    { new Guid("f1a8895e-47a4-4639-9f81-08a40fa9d141"), "الفصل الاول", "Second Semester" }
                });

            migrationBuilder.InsertData(
                table: "years",
                columns: new[] { "Id", "Name_AR", "Name_EN", "Order_of_theyear" },
                values: new object[,]
                {
                    { new Guid("33128b91-335c-4165-bb23-2cb47137c758"), "السنة الخامسة", "Fifth year", 5 },
                    { new Guid("5b6ef8d0-83ab-4c80-b18c-fa2463e898ce"), "السنة الثالثة", "Third year", 3 },
                    { new Guid("6d19766e-beaf-4901-8efa-d5528bd1633d"), "السنة االثانية", "Second year", 2 },
                    { new Guid("7e548a74-de8d-4a37-9941-214a4ebafaec"), "السنة الثامنة", "Eighth year", 8 },
                    { new Guid("95c01d52-7620-4dbb-a2b7-bafcbf1c0e14"), "السنة السادسة", "Sixth year", 6 },
                    { new Guid("bdba79de-f210-424e-950e-341748e6bca4"), "السنة السابعة", "Seventh year", 7 },
                    { new Guid("bdcf4362-3b12-4a0f-8f73-94293dc8b6ba"), "السنة الاولى", "First year", 1 },
                    { new Guid("e3d06b17-f85d-46b7-8f25-cc514deaacb8"), "السنة الرابعة", "Fourth year", 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "exams");

            migrationBuilder.DropTable(
                name: "lessons");

            migrationBuilder.DropTable(
                name: "lessonTimes");

            migrationBuilder.DeleteData(
                table: "semesters",
                keyColumn: "Id",
                keyValue: new Guid("5ff3b284-71eb-4602-b504-fdb7bcb2fb64"));

            migrationBuilder.DeleteData(
                table: "semesters",
                keyColumn: "Id",
                keyValue: new Guid("b64a7958-ef75-4802-bf5f-c53a7c55b818"));

            migrationBuilder.DeleteData(
                table: "semesters",
                keyColumn: "Id",
                keyValue: new Guid("f1a8895e-47a4-4639-9f81-08a40fa9d141"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("33128b91-335c-4165-bb23-2cb47137c758"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("5b6ef8d0-83ab-4c80-b18c-fa2463e898ce"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("6d19766e-beaf-4901-8efa-d5528bd1633d"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("7e548a74-de8d-4a37-9941-214a4ebafaec"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("95c01d52-7620-4dbb-a2b7-bafcbf1c0e14"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("bdba79de-f210-424e-950e-341748e6bca4"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("bdcf4362-3b12-4a0f-8f73-94293dc8b6ba"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("e3d06b17-f85d-46b7-8f25-cc514deaacb8"));

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
    }
}
