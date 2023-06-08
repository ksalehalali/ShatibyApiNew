using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShatibyApi.Migrations
{
    /// <inheritdoc />
    public partial class addsemesters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("012725fd-b4a5-4cbe-b639-556fbfb445c6"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("5b1133b6-aaf3-40b5-89e1-68e9a6c9c552"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("600bb29b-46c3-4b1e-81ed-525f0715024d"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("649ad43e-ec22-424f-a98b-a39405f93f78"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("9ab1e9f8-0738-498d-aba9-1a82033a0ef2"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("a1b7e588-b857-4b76-9045-77daf52622a6"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("d37648a8-bfa8-4aae-aedb-830e0b42fe3e"));

            migrationBuilder.DeleteData(
                table: "years",
                keyColumn: "Id",
                keyValue: new Guid("fc9c21e6-2784-4dee-aa53-002f11763cc9"));

            migrationBuilder.CreateTable(
                name: "semesters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name_AR = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_semesters", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "semesters");

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

            migrationBuilder.InsertData(
                table: "years",
                columns: new[] { "Id", "Name_AR", "Name_EN", "Order_of_theyear" },
                values: new object[,]
                {
                    { new Guid("012725fd-b4a5-4cbe-b639-556fbfb445c6"), "السنة الاولى", "First year", 1 },
                    { new Guid("5b1133b6-aaf3-40b5-89e1-68e9a6c9c552"), "السنة الرابعة", "Fourth year", 4 },
                    { new Guid("600bb29b-46c3-4b1e-81ed-525f0715024d"), "السنة السادسة", "Sixth year", 6 },
                    { new Guid("649ad43e-ec22-424f-a98b-a39405f93f78"), "السنة الثامنة", "Eighth year", 8 },
                    { new Guid("9ab1e9f8-0738-498d-aba9-1a82033a0ef2"), "السنة الثالثة", "Third year", 3 },
                    { new Guid("a1b7e588-b857-4b76-9045-77daf52622a6"), "السنة السابعة", "Seventh year", 7 },
                    { new Guid("d37648a8-bfa8-4aae-aedb-830e0b42fe3e"), "السنة االثانية", "Second year", 2 },
                    { new Guid("fc9c21e6-2784-4dee-aa53-002f11763cc9"), "السنة الخامسة", "Fifth year", 5 }
                });
        }
    }
}
