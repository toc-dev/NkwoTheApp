using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NkwoTheApp.Migrations
{
    public partial class TableUpdate_Fk_StoreProduct_Name : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_STORE_PRODUCT_StoreProductId",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_STORE_PRODUCT_Product_ProductId",
                table: "STORE_PRODUCT");

            migrationBuilder.DropForeignKey(
                name: "FK_STORE_PRODUCT_Seller_SellerId",
                table: "STORE_PRODUCT");

            migrationBuilder.DropPrimaryKey(
                name: "PK_STORE_PRODUCT",
                table: "STORE_PRODUCT");

            migrationBuilder.RenameTable(
                name: "STORE_PRODUCT",
                newName: "StoreProduct");

            migrationBuilder.RenameIndex(
                name: "IX_STORE_PRODUCT_SellerId",
                table: "StoreProduct",
                newName: "IX_StoreProduct_SellerId");

            migrationBuilder.RenameIndex(
                name: "IX_STORE_PRODUCT_ProductId",
                table: "StoreProduct",
                newName: "IX_StoreProduct_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoreProduct",
                table: "StoreProduct",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_StoreProduct_StoreProductId",
                table: "Cart",
                column: "StoreProductId",
                principalTable: "StoreProduct",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StoreProduct_Product_ProductId",
                table: "StoreProduct",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StoreProduct_Seller_SellerId",
                table: "StoreProduct",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_StoreProduct_StoreProductId",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreProduct_Product_ProductId",
                table: "StoreProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreProduct_Seller_SellerId",
                table: "StoreProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StoreProduct",
                table: "StoreProduct");

            migrationBuilder.RenameTable(
                name: "StoreProduct",
                newName: "STORE_PRODUCT");

            migrationBuilder.RenameIndex(
                name: "IX_StoreProduct_SellerId",
                table: "STORE_PRODUCT",
                newName: "IX_STORE_PRODUCT_SellerId");

            migrationBuilder.RenameIndex(
                name: "IX_StoreProduct_ProductId",
                table: "STORE_PRODUCT",
                newName: "IX_STORE_PRODUCT_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_STORE_PRODUCT",
                table: "STORE_PRODUCT",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_STORE_PRODUCT_StoreProductId",
                table: "Cart",
                column: "StoreProductId",
                principalTable: "STORE_PRODUCT",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_STORE_PRODUCT_Product_ProductId",
                table: "STORE_PRODUCT",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_STORE_PRODUCT_Seller_SellerId",
                table: "STORE_PRODUCT",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
