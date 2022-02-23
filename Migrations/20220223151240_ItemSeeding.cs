using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_5_Web_Api_Portfolio_Project.Migrations
{
    public partial class ItemSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "AmountInWarehouse", "Description", "Name", "Ratting" },
                values: new object[,]
                {
                    { 1, 100, "A car", "Car", (byte)6 },
                    { 2, 56, "A carrot", "Carrot", (byte)3 },
                    { 3, 47, "A plant", "Plant", (byte)6 },
                    { 4, 5, "Boots", "Boots", (byte)6 },
                    { 5, 13, "A shovel", "Shovel", (byte)6 },
                    { 6, 17, "A chainsaw", "Chainsaw", (byte)6 },
                    { 7, 26, "A black bag", "Black bag", (byte)6 },
                    { 8, 59, "A bleach", "Bleach", (byte)6 },
                    { 9, 1234, "A poster", "Poster", (byte)6 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
