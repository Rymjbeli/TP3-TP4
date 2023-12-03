using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tp3.Migrations
{
    public partial class attribute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SignUpFree",
                table: "membershiptypes",
                newName: "SignUpFee");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SignUpFee",
                table: "membershiptypes",
                newName: "SignUpFree");
        }
    }
}
