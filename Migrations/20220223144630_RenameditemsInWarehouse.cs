using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_5_Web_Api_Portfolio_Project.Migrations
{
    public partial class RenameditemsInWarehouse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountInWarhouse",
                table: "Items");

            migrationBuilder.AddColumn<int>(
                name: "AmountInWarehouse",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountInWarehouse",
                table: "Items");

            migrationBuilder.AddColumn<long>(
                name: "AmountInWarhouse",
                table: "Items",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
