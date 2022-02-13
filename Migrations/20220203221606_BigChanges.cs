using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_5_Web_Api_Portfolio_Project.Migrations
{
    public partial class BigChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Carts");

            migrationBuilder.RenameColumn(
                name: "PassowrdSalt",
                table: "Users",
                newName: "PasswordSalt");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Items",
                newName: "AmountInWarhouse");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PasswordSalt",
                table: "Users",
                newName: "PassowrdSalt");

            migrationBuilder.RenameColumn(
                name: "AmountInWarhouse",
                table: "Items",
                newName: "Amount");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
