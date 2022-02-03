using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_5_Web_Api_Portfolio_Project.Migrations
{
    public partial class UserCartRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "Amount",
                table: "Items",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Items");
        }
    }
}
