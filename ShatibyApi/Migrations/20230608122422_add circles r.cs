using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShatibyApi.Migrations
{
    /// <inheritdoc />
    public partial class addcirclesr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<Guid>(
                name: "LevelId",
                table: "circles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SemesterId",
                table: "circles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "TeacherId",
                table: "circles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.CreateIndex(
                name: "IX_circles_LevelId",
                table: "circles",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_circles_SemesterId",
                table: "circles",
                column: "SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_circles_TeacherId",
                table: "circles",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_circles_levels_LevelId",
                table: "circles",
                column: "LevelId",
                principalTable: "levels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_circles_semesters_SemesterId",
                table: "circles",
                column: "SemesterId",
                principalTable: "semesters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_circles_teachers_TeacherId",
                table: "circles",
                column: "TeacherId",
                principalTable: "teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_circles_levels_LevelId",
                table: "circles");

            migrationBuilder.DropForeignKey(
                name: "FK_circles_semesters_SemesterId",
                table: "circles");

            migrationBuilder.DropForeignKey(
                name: "FK_circles_teachers_TeacherId",
                table: "circles");

            migrationBuilder.DropIndex(
                name: "IX_circles_LevelId",
                table: "circles");

            migrationBuilder.DropIndex(
                name: "IX_circles_SemesterId",
                table: "circles");

            migrationBuilder.DropIndex(
                name: "IX_circles_TeacherId",
                table: "circles");

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

            migrationBuilder.DropColumn(
                name: "LevelId",
                table: "circles");

            migrationBuilder.DropColumn(
                name: "SemesterId",
                table: "circles");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "circles");

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
    }
}
