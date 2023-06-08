using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShatibyApi.Migrations
{
    /// <inheritdoc />
    public partial class addstudents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("193e7c38-afb4-400c-be2c-c4ea61c2bf3c"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("38d0a48b-994c-4c0f-914b-4204a4415722"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("a9c9ffb9-f479-4be6-a605-3d964d5855c8"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("b2408e07-206c-4598-99cc-13c947ea8550"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("dbee5477-33ce-41ce-9efc-213490f5cf17"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("e12c2bdd-6f15-4c1c-b3dc-b54028fd0860"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("edea0d79-4471-4c19-a277-065c8b5a4ce9"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("fe1892b4-8b8b-4e35-bd9b-3febd3824cea"));

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name_AR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ege = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rigestered = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LevelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_students_levels_LevelId",
                        column: x => x.LevelId,
                        principalTable: "levels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_students_years_YearId",
                        column: x => x.YearId,
                        principalTable: "years",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "years",
                columns: new[] { "Id", "Name_AR", "Name_EN", "Order_of_theyear" },
                values: new object[,]
                {
                    { new Guid("11630a6a-d8cb-483c-87ca-eb8d1acda7b7"), "السنة السابعة", "Seventh year", 7 },
                    { new Guid("1cd0aa1c-0332-47a3-80f6-751ec9e245f3"), "السنة الخامسة", "Fifth year", 5 },
                    { new Guid("86dc0450-68ff-4138-98b7-6f89cd4cf98b"), "السنة الرابعة", "Fourth year", 4 },
                    { new Guid("9e8d59c6-39e8-45df-8c39-6cf6af7198e0"), "السنة الثالثة", "Third year", 3 },
                    { new Guid("9f5c9a89-d9a9-4641-b9cd-255b26e0762e"), "السنة السادسة", "Sixth year", 6 },
                    { new Guid("aa8c1f3a-57c4-43af-ac58-fc8b74d46f30"), "السنة الثامنة", "Eighth year", 8 },
                    { new Guid("cd66b4d6-5e7b-439c-bab0-820b5b0f2d46"), "السنة الاولى", "First year", 1 },
                    { new Guid("fdd09f2f-21d2-406a-9b19-6c15c9ff5cbf"), "السنة االثانية", "Second year", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_students_LevelId",
                table: "students",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_students_YearId",
                table: "students",
                column: "YearId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("11630a6a-d8cb-483c-87ca-eb8d1acda7b7"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("1cd0aa1c-0332-47a3-80f6-751ec9e245f3"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("86dc0450-68ff-4138-98b7-6f89cd4cf98b"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("9e8d59c6-39e8-45df-8c39-6cf6af7198e0"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("9f5c9a89-d9a9-4641-b9cd-255b26e0762e"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("aa8c1f3a-57c4-43af-ac58-fc8b74d46f30"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("cd66b4d6-5e7b-439c-bab0-820b5b0f2d46"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("fdd09f2f-21d2-406a-9b19-6c15c9ff5cbf"));

            migrationBuilder.InsertData(
                table: "years",
                columns: new[] { "Id", "Name_AR", "Name_EN", "Order_of_theyear" },
                values: new object[,]
                {
                    { new Guid("193e7c38-afb4-400c-be2c-c4ea61c2bf3c"), "السنة السادسة", "Sixth year", 6 },
                    { new Guid("38d0a48b-994c-4c0f-914b-4204a4415722"), "السنة الثالثة", "Third year", 3 },
                    { new Guid("a9c9ffb9-f479-4be6-a605-3d964d5855c8"), "السنة السابعة", "Seventh year", 7 },
                    { new Guid("b2408e07-206c-4598-99cc-13c947ea8550"), "السنة االثانية", "Second year", 2 },
                    { new Guid("dbee5477-33ce-41ce-9efc-213490f5cf17"), "السنة الرابعة", "Fourth year", 4 },
                    { new Guid("e12c2bdd-6f15-4c1c-b3dc-b54028fd0860"), "السنة الاولى", "First year", 1 },
                    { new Guid("edea0d79-4471-4c19-a277-065c8b5a4ce9"), "السنة الخامسة", "Fifth year", 5 },
                    { new Guid("fe1892b4-8b8b-4e35-bd9b-3febd3824cea"), "السنة الثامنة", "Eighth year", 8 }
                });
        }
    }
}
