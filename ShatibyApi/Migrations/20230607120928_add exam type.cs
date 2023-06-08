using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShatibyApi.Migrations
{
    /// <inheritdoc />
    public partial class addexamtype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "examTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name_AR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Degree = table.Column<double>(type: "float", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_examTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "years",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name_AR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order_of_theyear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_years", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "examTypes",
                columns: new[] { "Id", "Degree", "Name_AR", "Name_EN", "UserID" },
                values: new object[,]
                {
                    { new Guid("1b8215e3-89c6-4a18-8735-210df4092ef7"), 50.0, "الامتحان الكتابي", "Written examination", new Guid("a11d8662-ae8e-479e-9f72-fa0771ba924f") },
                    { new Guid("5a700e51-8107-4fb5-98a2-b59508f4ea08"), 50.0, "الامتحان الشفوي", "Oral examination", new Guid("cc300768-d7a0-41b4-b784-d9ec669a9b77") },
                    { new Guid("77facf2c-6456-480e-9adc-5229257eec52"), 50.0, "الامتحان النهائي", "Final exam", new Guid("272aaf1c-92bd-415f-bf7f-1bd8348a634c") }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "examTypes");

            migrationBuilder.DropTable(
                name: "years");
        }
    }
}
