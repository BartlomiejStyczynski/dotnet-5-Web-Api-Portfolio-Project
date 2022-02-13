using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_5_Web_Api_Portfolio_Project.Migrations
{
    public partial class UserNicknameChangedtoUserUsername : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nickname",
                table: "Users",
                newName: "Username");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Users",
                newName: "Nickname");
        }
    }
}
