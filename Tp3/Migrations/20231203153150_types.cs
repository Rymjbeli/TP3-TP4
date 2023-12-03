using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tp3.Migrations
{
    public partial class types : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                        table: "membershiptypes",
                        columns: new[] { "Id", "Name", "SignUpFee", "DurationInMonth", "DiscountRate" },
                        values: new object[,]
                    {
            { 1 , "Normal", "60", "1", "0" },
            { 2 , "Silver", "170", "3", "5" },
            { 3 , "Gold", "310", "6", "14" },
            { 4 , "Diamond", "580", "12", "19" },
                    });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
