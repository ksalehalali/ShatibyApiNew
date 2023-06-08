using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShatibyApi.Migrations
{
    /// <inheritdoc />
    public partial class adddonations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("8243609d-8ee6-43c2-b3e2-651edf50fe54"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("8ba8e83b-d5bf-4258-a2a8-12ae7388790d"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("8f440157-b098-41f5-87da-9b508ea202ae"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("aeb634fa-db04-4c9a-84be-b2cdc682e10a"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("b1c4fb8e-4888-4705-9609-adbe35f7ed06"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("d34fd48c-854e-418b-99b9-6c8c845a0014"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("ea705215-5873-4d1c-b8cc-b1b30b96b613"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("f45bc4f1-7f83-4a21-915b-e37e09d9ce73"));

            migrationBuilder.CreateTable(
                name: "donations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TheDonorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TheDonor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_donations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "expenses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_expenses", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "donations");

            migrationBuilder.DropTable(
                name: "expenses");

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

            migrationBuilder.InsertData(
                table: "years",
                columns: new[] { "Id", "Name_AR", "Name_EN", "Order_of_theyear" },
                values: new object[,]
                {
                    { new Guid("8243609d-8ee6-43c2-b3e2-651edf50fe54"), "السنة السابعة", "Seventh year", 7 },
                    { new Guid("8ba8e83b-d5bf-4258-a2a8-12ae7388790d"), "السنة الثالثة", "Third year", 3 },
                    { new Guid("8f440157-b098-41f5-87da-9b508ea202ae"), "السنة االثانية", "Second year", 2 },
                    { new Guid("aeb634fa-db04-4c9a-84be-b2cdc682e10a"), "السنة الخامسة", "Fifth year", 5 },
                    { new Guid("b1c4fb8e-4888-4705-9609-adbe35f7ed06"), "السنة السادسة", "Sixth year", 6 },
                    { new Guid("d34fd48c-854e-418b-99b9-6c8c845a0014"), "السنة الرابعة", "Fourth year", 4 },
                    { new Guid("ea705215-5873-4d1c-b8cc-b1b30b96b613"), "السنة الثامنة", "Eighth year", 8 },
                    { new Guid("f45bc4f1-7f83-4a21-915b-e37e09d9ce73"), "السنة الاولى", "First year", 1 }
                });
        }
    }
}
