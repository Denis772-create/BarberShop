using Microsoft.EntityFrameworkCore.Migrations;

namespace Barber_Shop_Project.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FName", "LName", "MobilePhone", "Position" },
                values: new object[] { 1L, "Denis", "Alejandro", "+375292436302", "Hairdresser" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FName", "LName", "MobilePhone", "Position" },
                values: new object[] { 2L, "George", "Fletcher", "+375292436300", "Hairdresser" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FName", "LName", "MobilePhone", "Position" },
                values: new object[] { 3L, "Oliver", " O’Neal", "+375292856302", "Hairdresser" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FName", "LName", "MobilePhone", "Position" },
                values: new object[] { 4L, "Peter", "Hampton", "+375292436356", "Hairdresser" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FName", "LName", "MobilePhone", "Position" },
                values: new object[] { 5L, "Terence", "Floyd", "+375292436323", "Hairdresser" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FName", "LName", "MobilePhone", "Position" },
                values: new object[] { 6L, "Matthew", "Johnson", "+3752924363087", "Hairdresser" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6L);
        }
    }
}
