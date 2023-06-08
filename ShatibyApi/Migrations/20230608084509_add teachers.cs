using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShatibyApi.Migrations
{
    /// <inheritdoc />
    public partial class addteachers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    LevelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                name: "IX_teachers_LevelId",
                table: "teachers",
                column: "LevelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "teachers");

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
        }
    }
}
