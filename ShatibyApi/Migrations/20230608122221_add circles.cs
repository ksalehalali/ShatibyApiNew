using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShatibyApi.Migrations
{
    /// <inheritdoc />
    public partial class addcircles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "attendances",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attendances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "circles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LessonsCount = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_circles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "semesters",
                columns: new[] { "Id", "Name_AR", "Name_EN" },
                values: new object[,]
                {
                    { new Guid("11bc7f4c-6cfc-432e-a154-7a6f76ff707d"), "الفصل الاول", "First Semester" },
                    { new Guid("610f0f04-1b5d-4e9e-bf22-85df6118b53e"), "الفصل التكميلي", "Supplementary semester" },
                    { new Guid("6196b567-b1e2-42f8-8cc7-662c988d5f18"), "الفصل الاول", "Second Semester" }
                });

            migrationBuilder.InsertData(
                table: "years",
                columns: new[] { "Id", "Name_AR", "Name_EN", "Order_of_theyear" },
                values: new object[,]
                {
                    { new Guid("24406844-9c1f-4189-b0e5-fcf8f5dac341"), "السنة االثانية", "Second year", 2 },
                    { new Guid("4ae58d98-de1e-4d00-b72e-5b51bd3dee45"), "السنة الخامسة", "Fifth year", 5 },
                    { new Guid("71be8e83-eb65-4ab9-82fe-20f514554bcb"), "السنة الاولى", "First year", 1 },
                    { new Guid("7a58db57-cf08-47c1-a3c8-2dcfe1ddd00c"), "السنة الثامنة", "Eighth year", 8 },
                    { new Guid("a7b15279-32c9-4f22-831c-61985dac9b15"), "السنة الثالثة", "Third year", 3 },
                    { new Guid("b633c525-1b36-42b0-9ac9-0bef08387c56"), "السنة السادسة", "Sixth year", 6 },
                    { new Guid("bee4223e-3129-428c-9c66-d7e2be4a2ffe"), "السنة السابعة", "Seventh year", 7 },
                    { new Guid("e776532b-727a-4dbe-9712-1d5bc18e4d08"), "السنة الرابعة", "Fourth year", 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "attendances");

            migrationBuilder.DropTable(
                name: "circles");

            migrationBuilder.DeleteData(
                table: "semesters",
                keyColumn: "Id",
                keyValue: new Guid("11bc7f4c-6cfc-432e-a154-7a6f76ff707d"));

            migrationBuilder.DeleteData(
                table: "semesters",
                keyColumn: "Id",
                keyValue: new Guid("610f0f04-1b5d-4e9e-bf22-85df6118b53e"));

            migrationBuilder.DeleteData(
                table: "semesters",
                keyColumn: "Id",
                keyValue: new Guid("6196b567-b1e2-42f8-8cc7-662c988d5f18"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("24406844-9c1f-4189-b0e5-fcf8f5dac341"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("4ae58d98-de1e-4d00-b72e-5b51bd3dee45"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("71be8e83-eb65-4ab9-82fe-20f514554bcb"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("7a58db57-cf08-47c1-a3c8-2dcfe1ddd00c"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("a7b15279-32c9-4f22-831c-61985dac9b15"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("b633c525-1b36-42b0-9ac9-0bef08387c56"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("bee4223e-3129-428c-9c66-d7e2be4a2ffe"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("e776532b-727a-4dbe-9712-1d5bc18e4d08"));

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
    }
}
