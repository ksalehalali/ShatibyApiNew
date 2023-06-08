using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShatibyApi.Migrations
{
    /// <inheritdoc />
    public partial class addteacherrb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("65f7c747-ff7e-47bd-9e54-c00c68f7656a"), "الفصل الاول", "First Semester" },
                    { new Guid("6dbf9242-22de-460a-bcba-303d026f4f62"), "الفصل التكميلي", "Supplementary semester" },
                    { new Guid("efee8343-5eb0-48ab-a7f5-625bf24e6a22"), "الفصل الاول", "Second Semester" }
                });

            migrationBuilder.InsertData(
                table: "years",
                columns: new[] { "Id", "Name_AR", "Name_EN", "Order_of_theyear" },
                values: new object[,]
                {
                    { new Guid("14fd4bc4-dfc1-4454-b8d7-bf1e60f1a9f3"), "السنة السابعة", "Seventh year", 7 },
                    { new Guid("1951606b-0fe7-41f1-9ea4-5b59e6181b39"), "السنة الخامسة", "Fifth year", 5 },
                    { new Guid("3c0a93e5-d097-4cd4-8f4b-65d681954c0f"), "السنة الرابعة", "Fourth year", 4 },
                    { new Guid("52a6cbb1-0305-4179-997e-0932cbb2b9a8"), "السنة الاولى", "First year", 1 },
                    { new Guid("8ee6e38b-8d07-44fc-a3a3-d4ee55e6a390"), "السنة االثانية", "Second year", 2 },
                    { new Guid("a03c5f89-db70-44db-969c-c797f5099c92"), "السنة الثالثة", "Third year", 3 },
                    { new Guid("b7b99609-a153-42a8-a8e1-a9316172c152"), "السنة السادسة", "Sixth year", 6 },
                    { new Guid("fba51c86-08ee-403c-b016-184df3379210"), "السنة الثامنة", "Eighth year", 8 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "semesters",
                keyColumn: "Id",
                keyValue: new Guid("65f7c747-ff7e-47bd-9e54-c00c68f7656a"));

            migrationBuilder.DeleteData(
                table: "semesters",
                keyColumn: "Id",
                keyValue: new Guid("6dbf9242-22de-460a-bcba-303d026f4f62"));

            migrationBuilder.DeleteData(
                table: "semesters",
                keyColumn: "Id",
                keyValue: new Guid("efee8343-5eb0-48ab-a7f5-625bf24e6a22"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("14fd4bc4-dfc1-4454-b8d7-bf1e60f1a9f3"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("1951606b-0fe7-41f1-9ea4-5b59e6181b39"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("3c0a93e5-d097-4cd4-8f4b-65d681954c0f"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("52a6cbb1-0305-4179-997e-0932cbb2b9a8"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("8ee6e38b-8d07-44fc-a3a3-d4ee55e6a390"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("a03c5f89-db70-44db-969c-c797f5099c92"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("b7b99609-a153-42a8-a8e1-a9316172c152"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("fba51c86-08ee-403c-b016-184df3379210"));

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
    }
}
