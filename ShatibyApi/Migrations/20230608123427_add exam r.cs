using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShatibyApi.Migrations
{
    /// <inheritdoc />
    public partial class addexamr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "CircleId",
                table: "exams",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "semesters",
                columns: new[] { "Id", "Name_AR", "Name_EN" },
                values: new object[,]
                {
                    { new Guid("5883c8c0-c6a4-4622-b20f-946532bf7ade"), "الفصل الاول", "Second Semester" },
                    { new Guid("b660dcf8-0e44-42f4-b2d4-5983976e01ff"), "الفصل الاول", "First Semester" },
                    { new Guid("ef8da86f-5f41-4dba-95c3-b13c7d8762e4"), "الفصل التكميلي", "Supplementary semester" }
                });

            migrationBuilder.InsertData(
                table: "years",
                columns: new[] { "Id", "Name_AR", "Name_EN", "Order_of_theyear" },
                values: new object[,]
                {
                    { new Guid("239f0fd9-f5b0-4adf-81d1-a816fc5e3b76"), "السنة الاولى", "First year", 1 },
                    { new Guid("3fe42744-f1a0-43b2-adc1-1fc6eb838c2e"), "السنة االثانية", "Second year", 2 },
                    { new Guid("4be046bc-d118-45a4-98ec-552cc2819239"), "السنة الثالثة", "Third year", 3 },
                    { new Guid("51247b39-59f3-4015-a82c-31470ab9c83f"), "السنة الثامنة", "Eighth year", 8 },
                    { new Guid("973b0e33-4984-43c2-9493-651d4935ff7b"), "السنة الرابعة", "Fourth year", 4 },
                    { new Guid("a0cb4784-ad22-4c09-9c24-d41c21141036"), "السنة الخامسة", "Fifth year", 5 },
                    { new Guid("ca8c94cd-03a1-44a1-af2d-0132d6c6109b"), "السنة السابعة", "Seventh year", 7 },
                    { new Guid("d67a2d21-07f6-47be-ba9a-c24ee045c29b"), "السنة السادسة", "Sixth year", 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_exams_CircleId",
                table: "exams",
                column: "CircleId");

            migrationBuilder.AddForeignKey(
                name: "FK_exams_circles_CircleId",
                table: "exams",
                column: "CircleId",
                principalTable: "circles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_exams_circles_CircleId",
                table: "exams");

            migrationBuilder.DropIndex(
                name: "IX_exams_CircleId",
                table: "exams");

            migrationBuilder.DeleteData(
                table: "semesters",
                keyColumn: "Id",
                keyValue: new Guid("5883c8c0-c6a4-4622-b20f-946532bf7ade"));

            migrationBuilder.DeleteData(
                table: "semesters",
                keyColumn: "Id",
                keyValue: new Guid("b660dcf8-0e44-42f4-b2d4-5983976e01ff"));

            migrationBuilder.DeleteData(
                table: "semesters",
                keyColumn: "Id",
                keyValue: new Guid("ef8da86f-5f41-4dba-95c3-b13c7d8762e4"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("239f0fd9-f5b0-4adf-81d1-a816fc5e3b76"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("3fe42744-f1a0-43b2-adc1-1fc6eb838c2e"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("4be046bc-d118-45a4-98ec-552cc2819239"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("51247b39-59f3-4015-a82c-31470ab9c83f"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("973b0e33-4984-43c2-9493-651d4935ff7b"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("a0cb4784-ad22-4c09-9c24-d41c21141036"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("ca8c94cd-03a1-44a1-af2d-0132d6c6109b"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("d67a2d21-07f6-47be-ba9a-c24ee045c29b"));

            migrationBuilder.DropColumn(
                name: "CircleId",
                table: "exams");

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
    }
}
