using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShatibyApi.Migrations
{
    /// <inheritdoc />
    public partial class addteacherr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "semesters",
                keyColumn: "Id",
                keyValue: new Guid("61da3640-c274-42e5-bb73-322a46303a1a"));

            migrationBuilder.DeleteData(
                table: "semesters",
                keyColumn: "Id",
                keyValue: new Guid("9e001eb4-9f6c-40d5-9e86-6b7f69e01ab8"));

            migrationBuilder.DeleteData(
                table: "semesters",
                keyColumn: "Id",
                keyValue: new Guid("d86f42a0-969c-40ea-94fa-ef09cd3b7aef"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("1757e26e-2791-45e4-8838-191abb1935cf"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("47e00288-73ab-4259-8f33-30ce08592db4"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("4c63b61c-520f-4597-b65a-ca3ccbdf71c5"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("5302ad5e-1d35-4526-925d-ef397385a41b"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("5b7170e9-a725-4fc6-a423-0f14d34866eb"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("a4bb0153-40fa-4edd-a7ab-f2b3116e2e07"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("b2d5f6ff-113f-49ae-a020-ebd751128a5f"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("d4c58127-23c8-47fc-a876-19763df01411"));

            migrationBuilder.AddColumn<Guid>(
                name: "LevelId",
                table: "teachers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "semesters",
                columns: new[] { "Id", "Name_AR", "Name_EN" },
                values: new object[,]
                {
                    { new Guid("05d7e125-cab0-456d-8e3f-b1057f7ca0e9"), "الفصل الاول", "Second Semester" },
                    { new Guid("8d165cff-d767-4d54-ba77-b4fa3b3a813e"), "الفصل التكميلي", "Supplementary semester" },
                    { new Guid("ba7e2315-4f0e-43d9-bf20-a5064c9fe4d9"), "الفصل الاول", "First Semester" }
                });

            migrationBuilder.InsertData(
                table: "years",
                columns: new[] { "Id", "Name_AR", "Name_EN", "Order_of_theyear" },
                values: new object[,]
                {
                    { new Guid("1566b38b-e74d-4815-8e05-081e6c81f00e"), "السنة السابعة", "Seventh year", 7 },
                    { new Guid("4a08b856-1cca-4c72-bc3c-d0c86162add2"), "السنة الاولى", "First year", 1 },
                    { new Guid("61d22e40-1841-4d5b-9fde-9b5ed74d9bf1"), "السنة االثانية", "Second year", 2 },
                    { new Guid("67550298-7d2e-441b-9bda-483f599ee2a8"), "السنة الرابعة", "Fourth year", 4 },
                    { new Guid("71d9e5bd-a723-4fdd-a512-38cdafb1d99c"), "السنة الثامنة", "Eighth year", 8 },
                    { new Guid("a71d20c6-1897-426a-80f0-ba174cbcaffc"), "السنة الثالثة", "Third year", 3 },
                    { new Guid("c1a8a03c-c974-4a4e-a824-1c0e9b817daa"), "السنة السادسة", "Sixth year", 6 },
                    { new Guid("d7740361-cfdb-4c4a-b9a0-3cfd6a5aeb9c"), "السنة الخامسة", "Fifth year", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_teachers_LevelId",
                table: "teachers",
                column: "LevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_teachers_levels_LevelId",
                table: "teachers",
                column: "LevelId",
                principalTable: "levels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_teachers_levels_LevelId",
                table: "teachers");

            migrationBuilder.DropIndex(
                name: "IX_teachers_LevelId",
                table: "teachers");

            migrationBuilder.DeleteData(
                table: "semesters",
                keyColumn: "Id",
                keyValue: new Guid("05d7e125-cab0-456d-8e3f-b1057f7ca0e9"));

            migrationBuilder.DeleteData(
                table: "semesters",
                keyColumn: "Id",
                keyValue: new Guid("8d165cff-d767-4d54-ba77-b4fa3b3a813e"));

            migrationBuilder.DeleteData(
                table: "semesters",
                keyColumn: "Id",
                keyValue: new Guid("ba7e2315-4f0e-43d9-bf20-a5064c9fe4d9"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("1566b38b-e74d-4815-8e05-081e6c81f00e"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("4a08b856-1cca-4c72-bc3c-d0c86162add2"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("61d22e40-1841-4d5b-9fde-9b5ed74d9bf1"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("67550298-7d2e-441b-9bda-483f599ee2a8"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("71d9e5bd-a723-4fdd-a512-38cdafb1d99c"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("a71d20c6-1897-426a-80f0-ba174cbcaffc"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("c1a8a03c-c974-4a4e-a824-1c0e9b817daa"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("d7740361-cfdb-4c4a-b9a0-3cfd6a5aeb9c"));

            migrationBuilder.DropColumn(
                name: "LevelId",
                table: "teachers");

            migrationBuilder.InsertData(
                table: "semesters",
                columns: new[] { "Id", "Name_AR", "Name_EN" },
                values: new object[,]
                {
                    { new Guid("61da3640-c274-42e5-bb73-322a46303a1a"), "الفصل التكميلي", "Supplementary semester" },
                    { new Guid("9e001eb4-9f6c-40d5-9e86-6b7f69e01ab8"), "الفصل الاول", "First Semester" },
                    { new Guid("d86f42a0-969c-40ea-94fa-ef09cd3b7aef"), "الفصل الاول", "Second Semester" }
                });

            migrationBuilder.InsertData(
                table: "years",
                columns: new[] { "Id", "Name_AR", "Name_EN", "Order_of_theyear" },
                values: new object[,]
                {
                    { new Guid("1757e26e-2791-45e4-8838-191abb1935cf"), "السنة الاولى", "First year", 1 },
                    { new Guid("47e00288-73ab-4259-8f33-30ce08592db4"), "السنة الرابعة", "Fourth year", 4 },
                    { new Guid("4c63b61c-520f-4597-b65a-ca3ccbdf71c5"), "السنة الخامسة", "Fifth year", 5 },
                    { new Guid("5302ad5e-1d35-4526-925d-ef397385a41b"), "السنة االثانية", "Second year", 2 },
                    { new Guid("5b7170e9-a725-4fc6-a423-0f14d34866eb"), "السنة السابعة", "Seventh year", 7 },
                    { new Guid("a4bb0153-40fa-4edd-a7ab-f2b3116e2e07"), "السنة الثامنة", "Eighth year", 8 },
                    { new Guid("b2d5f6ff-113f-49ae-a020-ebd751128a5f"), "السنة السادسة", "Sixth year", 6 },
                    { new Guid("d4c58127-23c8-47fc-a876-19763df01411"), "السنة الثالثة", "Third year", 3 }
                });
        }
    }
}
