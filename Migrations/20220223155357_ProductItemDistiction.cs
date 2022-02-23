using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_5_Web_Api_Portfolio_Project.Migrations
{
    public partial class ProductItemDistiction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_ItemsInCart_ItemInCartId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Carts_CartId",
                table: "Items");

            migrationBuilder.DropTable(
                name: "ItemsInCart");

            migrationBuilder.DropIndex(
                name: "IX_Items_CartId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Carts_ItemInCartId",
                table: "Carts");

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

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ItemInCartId",
                table: "Carts");

            migrationBuilder.RenameColumn(
                name: "AmountInWarehouse",
                table: "Items",
                newName: "Quantity");

            migrationBuilder.AlterColumn<int>(
                name: "Ratting",
                table: "Items",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.CreateTable(
                name: "CartItem",
                columns: table => new
                {
                    CartsId = table.Column<int>(type: "int", nullable: false),
                    ItemListId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItem", x => new { x.CartsId, x.ItemListId });
                    table.ForeignKey(
                        name: "FK_CartItem_Carts_CartsId",
                        column: x => x.CartsId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItem_Items_ItemListId",
                        column: x => x.ItemListId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ratting = table.Column<byte>(type: "tinyint", nullable: false),
                    AmountInWarehouse = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
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

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_ItemListId",
                table: "CartItem",
                column: "ItemListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItem");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Items",
                newName: "AmountInWarehouse");

            migrationBuilder.AlterColumn<byte>(
                name: "Ratting",
                table: "Items",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemInCartId",
                table: "Carts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ItemsInCart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Ratting = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsInCart", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "AmountInWarehouse", "CartId", "Description", "Name", "Ratting" },
                values: new object[,]
                {
                    { 1, 100, null, "A car", "Car", (byte)6 },
                    { 2, 56, null, "A carrot", "Carrot", (byte)3 },
                    { 3, 47, null, "A plant", "Plant", (byte)6 },
                    { 4, 5, null, "Boots", "Boots", (byte)6 },
                    { 5, 13, null, "A shovel", "Shovel", (byte)6 },
                    { 6, 17, null, "A chainsaw", "Chainsaw", (byte)6 },
                    { 7, 26, null, "A black bag", "Black bag", (byte)6 },
                    { 8, 59, null, "A bleach", "Bleach", (byte)6 },
                    { 9, 1234, null, "A poster", "Poster", (byte)6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_CartId",
                table: "Items",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_ItemInCartId",
                table: "Carts",
                column: "ItemInCartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_ItemsInCart_ItemInCartId",
                table: "Carts",
                column: "ItemInCartId",
                principalTable: "ItemsInCart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Carts_CartId",
                table: "Items",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
