using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tp3.Migrations
{
    public partial class SeedGenres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "genres",
                columns: new[] { "Id", "GenreName" },
                values: new object[] { 1, "GenreFromJsonFile1" });

            migrationBuilder.InsertData(
                table: "genres",
                columns: new[] { "Id", "GenreName" },
                values: new object[] { 2, "GenreFromJsonFile2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "genres",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
