using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tp3.Migrations
{
    public partial class attribute1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "membershiptypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "membershiptypes");
        }
    }
}
