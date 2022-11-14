using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NkwoTheApp.Migrations
{
    public partial class DbRearrangementForProductAndProductDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buyer_User_UserId",
                table: "Buyer");

            migrationBuilder.DropForeignKey(
                name: "FK_Cart_Buyer_BuyerId",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_Cart_Product_ProductId",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_PriceOffer_Product_ProductId",
                table: "PriceOffer");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_StoreProduct_ProductDetailsId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Seller_User_UserId",
                table: "Seller");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreProduct_Seller_SellerId",
                table: "StoreProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Address_AddressId",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StoreProduct",
                table: "StoreProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Seller",
                table: "Seller");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_ProductDetailsId",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PriceOffer",
                table: "PriceOffer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cart",
                table: "Cart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Buyer",
                table: "Buyer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "ProductDetailsId",
                table: "Product");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "StoreProduct",
                newName: "ProductsDetails");

            migrationBuilder.RenameTable(
                name: "Seller",
                newName: "Sellers");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "PriceOffer",
                newName: "PriceOffers");

            migrationBuilder.RenameTable(
                name: "Cart",
                newName: "Carts");

            migrationBuilder.RenameTable(
                name: "Buyer",
                newName: "Buyers");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Addresses");

            migrationBuilder.RenameIndex(
                name: "IX_User_AddressId",
                table: "Users",
                newName: "IX_Users_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_StoreProduct_SellerId",
                table: "ProductsDetails",
                newName: "IX_ProductsDetails_SellerId");

            migrationBuilder.RenameIndex(
                name: "IX_Seller_UserId",
                table: "Sellers",
                newName: "IX_Sellers_UserId");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "PriceOffers",
                newName: "ProductDetailsId");

            migrationBuilder.RenameIndex(
                name: "IX_PriceOffer_ProductId",
                table: "PriceOffers",
                newName: "IX_PriceOffers_ProductDetailsId");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Carts",
                newName: "ProductDetailsId");

            migrationBuilder.RenameIndex(
                name: "IX_Cart_ProductId",
                table: "Carts",
                newName: "IX_Carts_ProductDetailsId");

            migrationBuilder.RenameIndex(
                name: "IX_Cart_BuyerId",
                table: "Carts",
                newName: "IX_Carts_BuyerId");

            migrationBuilder.RenameIndex(
                name: "IX_Buyer_UserId",
                table: "Buyers",
                newName: "IX_Buyers_UserId");

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Users",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "ProductsDetails",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "StreetNumber",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Region",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductsDetails",
                table: "ProductsDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sellers",
                table: "Sellers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PriceOffers",
                table: "PriceOffers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Buyers",
                table: "Buyers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("1246b007-018b-4028-aff8-dcc4bd1aec68"),
                column: "Street",
                value: "Spazosevic street");

            migrationBuilder.UpdateData(
                table: "ProductsDetails",
                keyColumn: "Id",
                keyValue: new Guid("0d034c9b-8e63-4838-af27-b13be57d1457"),
                columns: new[] { "CreatedAt", "ProductId" },
                values: new object[] { new DateTime(2022, 11, 13, 0, 49, 20, 672, DateTimeKind.Local).AddTicks(5597), new Guid("26b7667c-90c9-47b5-a722-3182fb32d599") });

            migrationBuilder.UpdateData(
                table: "ProductsDetails",
                keyColumn: "Id",
                keyValue: new Guid("dbca4d53-cbff-4847-8ada-859eca4f7b93"),
                columns: new[] { "CreatedAt", "ProductId" },
                values: new object[] { new DateTime(2022, 11, 13, 0, 49, 20, 672, DateTimeKind.Local).AddTicks(5574), new Guid("26b7667c-90c9-47b5-a722-3182fb32d599") });

            migrationBuilder.UpdateData(
                table: "ProductsDetails",
                keyColumn: "Id",
                keyValue: new Guid("f1592f94-4b9b-4515-90c4-31ef858dfcfa"),
                columns: new[] { "CreatedAt", "ProductId", "ShopName" },
                values: new object[] { new DateTime(2022, 11, 13, 0, 49, 20, 672, DateTimeKind.Local).AddTicks(5592), new Guid("26b7667c-90c9-47b5-a722-3182fb32d599"), "Lojiks Ventures" });

            migrationBuilder.InsertData(
                table: "ProductsDetails",
                columns: new[] { "Id", "CreatedAt", "Price", "ProductId", "Quantity", "SellerId", "ShopName", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("19e4ba4a-71f0-4390-8854-43dc041ebaa2"), new DateTime(2022, 11, 13, 0, 49, 20, 672, DateTimeKind.Local).AddTicks(5600), 90.00m, new Guid("b7dffa97-da56-4cbb-b5b3-93de39f0e06c"), 500, new Guid("1a859ecc-f1cd-422e-9130-bb73d68f86d9"), "Agamemnon And Sons", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2356b868-a13e-445d-9404-f1401e3f0faf"), new DateTime(2022, 11, 13, 0, 49, 20, 672, DateTimeKind.Local).AddTicks(5603), 90.00m, new Guid("deb46b24-6a60-4f9a-90f7-6f9d3314cb60"), 500, new Guid("1a859ecc-f1cd-422e-9130-bb73d68f86d9"), "Agamemnon And Sons", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("315947fe-0a5b-4f4d-bb3d-688306b475ab"),
                column: "DateOfBirth",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                column: "DateOfBirth",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_ProductsDetails_ProductId",
                table: "ProductsDetails",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Buyers_Users_UserId",
                table: "Buyers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Buyers_BuyerId",
                table: "Carts",
                column: "BuyerId",
                principalTable: "Buyers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_ProductsDetails_ProductDetailsId",
                table: "Carts",
                column: "ProductDetailsId",
                principalTable: "ProductsDetails",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PriceOffers_ProductsDetails_ProductDetailsId",
                table: "PriceOffers",
                column: "ProductDetailsId",
                principalTable: "ProductsDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsDetails_Products_ProductId",
                table: "ProductsDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsDetails_Sellers_SellerId",
                table: "ProductsDetails",
                column: "SellerId",
                principalTable: "Sellers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sellers_Users_UserId",
                table: "Sellers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Addresses_AddressId",
                table: "Users",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buyers_Users_UserId",
                table: "Buyers");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Buyers_BuyerId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_ProductsDetails_ProductDetailsId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_PriceOffers_ProductsDetails_ProductDetailsId",
                table: "PriceOffers");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsDetails_Products_ProductId",
                table: "ProductsDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsDetails_Sellers_SellerId",
                table: "ProductsDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Sellers_Users_UserId",
                table: "Sellers");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Addresses_AddressId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sellers",
                table: "Sellers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductsDetails",
                table: "ProductsDetails");

            migrationBuilder.DropIndex(
                name: "IX_ProductsDetails_ProductId",
                table: "ProductsDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PriceOffers",
                table: "PriceOffers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Buyers",
                table: "Buyers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.DeleteData(
                table: "ProductsDetails",
                keyColumn: "Id",
                keyValue: new Guid("19e4ba4a-71f0-4390-8854-43dc041ebaa2"));

            migrationBuilder.DeleteData(
                table: "ProductsDetails",
                keyColumn: "Id",
                keyValue: new Guid("2356b868-a13e-445d-9404-f1401e3f0faf"));

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductsDetails");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "Sellers",
                newName: "Seller");

            migrationBuilder.RenameTable(
                name: "ProductsDetails",
                newName: "StoreProduct");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "PriceOffers",
                newName: "PriceOffer");

            migrationBuilder.RenameTable(
                name: "Carts",
                newName: "Cart");

            migrationBuilder.RenameTable(
                name: "Buyers",
                newName: "Buyer");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "Address");

            migrationBuilder.RenameIndex(
                name: "IX_Users_AddressId",
                table: "User",
                newName: "IX_User_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Sellers_UserId",
                table: "Seller",
                newName: "IX_Seller_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductsDetails_SellerId",
                table: "StoreProduct",
                newName: "IX_StoreProduct_SellerId");

            migrationBuilder.RenameColumn(
                name: "ProductDetailsId",
                table: "PriceOffer",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_PriceOffers_ProductDetailsId",
                table: "PriceOffer",
                newName: "IX_PriceOffer_ProductId");

            migrationBuilder.RenameColumn(
                name: "ProductDetailsId",
                table: "Cart",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_ProductDetailsId",
                table: "Cart",
                newName: "IX_Cart_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_BuyerId",
                table: "Cart",
                newName: "IX_Cart_BuyerId");

            migrationBuilder.RenameIndex(
                name: "IX_Buyers_UserId",
                table: "Buyer",
                newName: "IX_Buyer_UserId");

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProductDetailsId",
                table: "Product",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "StreetNumber",
                table: "Address",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Address",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Region",
                table: "Address",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Address",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Address",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Seller",
                table: "Seller",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoreProduct",
                table: "StoreProduct",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PriceOffer",
                table: "PriceOffer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cart",
                table: "Cart",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Buyer",
                table: "Buyer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: new Guid("1246b007-018b-4028-aff8-dcc4bd1aec68"),
                column: "Street",
                value: "Spazosevic");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("26b7667c-90c9-47b5-a722-3182fb32d599"),
                column: "ProductDetailsId",
                value: new Guid("dbca4d53-cbff-4847-8ada-859eca4f7b93"));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b7dffa97-da56-4cbb-b5b3-93de39f0e06c"),
                column: "ProductDetailsId",
                value: new Guid("f1592f94-4b9b-4515-90c4-31ef858dfcfa"));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("deb46b24-6a60-4f9a-90f7-6f9d3314cb60"),
                column: "ProductDetailsId",
                value: new Guid("0d034c9b-8e63-4838-af27-b13be57d1457"));

            migrationBuilder.UpdateData(
                table: "StoreProduct",
                keyColumn: "Id",
                keyValue: new Guid("0d034c9b-8e63-4838-af27-b13be57d1457"),
                column: "CreatedAt",
                value: new DateTime(2022, 11, 2, 18, 59, 23, 441, DateTimeKind.Local).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "StoreProduct",
                keyColumn: "Id",
                keyValue: new Guid("dbca4d53-cbff-4847-8ada-859eca4f7b93"),
                column: "CreatedAt",
                value: new DateTime(2022, 11, 2, 18, 59, 23, 441, DateTimeKind.Local).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "StoreProduct",
                keyColumn: "Id",
                keyValue: new Guid("f1592f94-4b9b-4515-90c4-31ef858dfcfa"),
                columns: new[] { "CreatedAt", "ShopName" },
                values: new object[] { new DateTime(2022, 11, 2, 18, 59, 23, 441, DateTimeKind.Local).AddTicks(1925), "Agamemnon And Sons" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("315947fe-0a5b-4f4d-bb3d-688306b475ab"),
                column: "DateOfBirth",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                column: "DateOfBirth",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductDetailsId",
                table: "Product",
                column: "ProductDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Buyer_User_UserId",
                table: "Buyer",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_Buyer_BuyerId",
                table: "Cart",
                column: "BuyerId",
                principalTable: "Buyer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_Product_ProductId",
                table: "Cart",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PriceOffer_Product_ProductId",
                table: "PriceOffer",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_StoreProduct_ProductDetailsId",
                table: "Product",
                column: "ProductDetailsId",
                principalTable: "StoreProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_User_UserId",
                table: "Seller",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StoreProduct_Seller_SellerId",
                table: "StoreProduct",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Address_AddressId",
                table: "User",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
