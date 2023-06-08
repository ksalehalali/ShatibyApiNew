using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShatibyApi.Migrations
{
    /// <inheritdoc />
    public partial class addevent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("29b6ce07-0fa3-4079-9547-2c8aed1369c1"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("3724b50f-abfb-4f40-9fea-4be63a0ce7db"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("469ddd21-3c9e-48c8-a200-aa95c8630475"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("5a2ae5d6-aa45-43e3-bd53-63442cf7115f"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("66484279-b58f-443e-91fe-0ff03b129826"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("a410e756-5138-40fe-a861-84cfbb16d4fa"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("c85014e0-268e-45b3-962d-72f337df0a59"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("cc440fea-21db-4629-bd98-3faaec079a4e"));

            migrationBuilder.CreateTable(
                name: "events",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name_AR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description_AR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_events", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "years",
                columns: new[] { "Id", "Name_AR", "Name_EN", "Order_of_theyear" },
                values: new object[,]
                {
                    { new Guid("25cf62ef-6f8b-45d9-aedf-2b9ca2ad28f9"), "السنة الاولى", "First year", 1 },
                    { new Guid("8213f109-38a8-455e-9edf-4e6632cbeb0f"), "السنة الرابعة", "Fourth year", 4 },
                    { new Guid("931b1ee5-fefd-45f4-b5cc-3643f01db691"), "السنة السادسة", "Sixth year", 6 },
                    { new Guid("98a6fa48-5261-49a6-a3b3-08d582c598b8"), "السنة الثالثة", "Third year", 3 },
                    { new Guid("b1b391f2-6386-4068-a7ec-ce55976cfbd7"), "السنة السابعة", "Seventh year", 7 },
                    { new Guid("b4084c2e-d74c-44ce-a12a-9fb92f0d8e71"), "السنة االثانية", "Second year", 2 },
                    { new Guid("c3d9e583-318a-4a9b-90c7-41b6a1e15109"), "السنة الخامسة", "Fifth year", 5 },
                    { new Guid("e17bebe4-9721-44db-85e3-a0e59d318c1c"), "السنة الثامنة", "Eighth year", 8 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "events");

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("25cf62ef-6f8b-45d9-aedf-2b9ca2ad28f9"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("8213f109-38a8-455e-9edf-4e6632cbeb0f"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("931b1ee5-fefd-45f4-b5cc-3643f01db691"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("98a6fa48-5261-49a6-a3b3-08d582c598b8"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("b1b391f2-6386-4068-a7ec-ce55976cfbd7"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("b4084c2e-d74c-44ce-a12a-9fb92f0d8e71"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("c3d9e583-318a-4a9b-90c7-41b6a1e15109"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("e17bebe4-9721-44db-85e3-a0e59d318c1c"));

            migrationBuilder.InsertData(
                table: "years",
                columns: new[] { "Id", "Name_AR", "Name_EN", "Order_of_theyear" },
                values: new object[,]
                {
                    { new Guid("29b6ce07-0fa3-4079-9547-2c8aed1369c1"), "السنة الرابعة", "Fourth year", 4 },
                    { new Guid("3724b50f-abfb-4f40-9fea-4be63a0ce7db"), "السنة الاولى", "First year", 1 },
                    { new Guid("469ddd21-3c9e-48c8-a200-aa95c8630475"), "السنة االثانية", "Second year", 2 },
                    { new Guid("5a2ae5d6-aa45-43e3-bd53-63442cf7115f"), "السنة السادسة", "Sixth year", 6 },
                    { new Guid("66484279-b58f-443e-91fe-0ff03b129826"), "السنة السابعة", "Seventh year", 7 },
                    { new Guid("a410e756-5138-40fe-a861-84cfbb16d4fa"), "السنة الخامسة", "Fifth year", 5 },
                    { new Guid("c85014e0-268e-45b3-962d-72f337df0a59"), "السنة الثامنة", "Eighth year", 8 },
                    { new Guid("cc440fea-21db-4629-bd98-3faaec079a4e"), "السنة الثالثة", "Third year", 3 }
                });
        }
    }
}
