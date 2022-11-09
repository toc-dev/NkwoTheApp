using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NkwoTheApp.Migrations
{
    public partial class NewTablesAndDataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_StoreProduct_StoreProductId",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreProduct_Product_ProductId",
                table: "StoreProduct");

            migrationBuilder.DropIndex(
                name: "IX_StoreProduct_ProductId",
                table: "StoreProduct");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "StoreProduct");

            migrationBuilder.RenameColumn(
                name: "StoreProductId",
                table: "Cart",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Cart_StoreProductId",
                table: "Cart",
                newName: "IX_Cart_ProductId");

            migrationBuilder.AlterColumn<string>(
                name: "ReferralCode",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "OtherName",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ImageURL",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<Guid>(
                name: "AddressId",
                table: "User",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ProductDetailsId",
                table: "Product",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PriceOffer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NewPrice = table.Column<decimal>(type: "decimal(20,8)", nullable: false),
                    PromotionalText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceOffer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PriceOffer_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Country", "Region", "Street", "StreetNumber" },
                values: new object[] { new Guid("1246b007-018b-4028-aff8-dcc4bd1aec68"), "Kyiv", "Ukraine", "Donbas", "Spazosevic", "1213" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "Country", "Region", "Street", "StreetNumber" },
                values: new object[] { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "Enugu", "Nigeria", "South-East", "Nza Street", "24" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AddressId", "CreatedAt", "DateOfBirth", "EmailAddress", "FirstName", "Gender", "ImageURL", "LastName", "OtherName", "PersonType", "PhoneNumber", "ReferralCode", "RegistrationStatus", "UpdatedAt", "Username" },
                values: new object[] { new Guid("315947fe-0a5b-4f4d-bb3d-688306b475ab"), new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tochukwusage@gmail.com", "Tochukwu", 1, null, "Nwokolo", null, 2, "+234-706-5432-123", null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tochukwusage" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AddressId", "CreatedAt", "DateOfBirth", "EmailAddress", "FirstName", "Gender", "ImageURL", "LastName", "OtherName", "PersonType", "PhoneNumber", "ReferralCode", "RegistrationStatus", "UpdatedAt", "Username" },
                values: new object[] { new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), new Guid("1246b007-018b-4028-aff8-dcc4bd1aec68"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iberia@gmail.com", "Marinko", 1, null, "Spazevovic", null, 1, "+21-345-4567-987", null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iberia" });

            migrationBuilder.InsertData(
                table: "Buyer",
                columns: new[] { "Id", "CreatedAt", "RegistrationStatus", "UpdatedAt", "UserId" },
                values: new object[] { new Guid("2dc01af8-ffc3-4468-b80d-38d6fef11b34"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("80abbca8-664d-4b20-b5de-024705497d4a") });

            migrationBuilder.InsertData(
                table: "Seller",
                columns: new[] { "Id", "CreatedAt", "RegistrationStatus", "UpdatedAt", "UserId" },
                values: new object[] { new Guid("1a859ecc-f1cd-422e-9130-bb73d68f86d9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("315947fe-0a5b-4f4d-bb3d-688306b475ab") });

            migrationBuilder.InsertData(
                table: "StoreProduct",
                columns: new[] { "Id", "CreatedAt", "Price", "Quantity", "SellerId", "ShopName", "UpdatedAt" },
                values: new object[] { new Guid("0d034c9b-8e63-4838-af27-b13be57d1457"), new DateTime(2022, 11, 2, 18, 59, 23, 441, DateTimeKind.Local).AddTicks(1928), 90.00m, 500, new Guid("1a859ecc-f1cd-422e-9130-bb73d68f86d9"), "Agamemnon And Sons", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "StoreProduct",
                columns: new[] { "Id", "CreatedAt", "Price", "Quantity", "SellerId", "ShopName", "UpdatedAt" },
                values: new object[] { new Guid("dbca4d53-cbff-4847-8ada-859eca4f7b93"), new DateTime(2022, 11, 2, 18, 59, 23, 441, DateTimeKind.Local).AddTicks(1915), 1045.00m, 40, new Guid("1a859ecc-f1cd-422e-9130-bb73d68f86d9"), "Agamemnon And Sons", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "StoreProduct",
                columns: new[] { "Id", "CreatedAt", "Price", "Quantity", "SellerId", "ShopName", "UpdatedAt" },
                values: new object[] { new Guid("f1592f94-4b9b-4515-90c4-31ef858dfcfa"), new DateTime(2022, 11, 2, 18, 59, 23, 441, DateTimeKind.Local).AddTicks(1925), 50.00m, 50, new Guid("1a859ecc-f1cd-422e-9130-bb73d68f86d9"), "Agamemnon And Sons", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Category", "CreatedAt", "Name", "ProductDetailsId", "UpdatedAt" },
                values: new object[] { new Guid("26b7667c-90c9-47b5-a722-3182fb32d599"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IPhone 14", new Guid("dbca4d53-cbff-4847-8ada-859eca4f7b93"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Category", "CreatedAt", "Name", "ProductDetailsId", "UpdatedAt" },
                values: new object[] { new Guid("b7dffa97-da56-4cbb-b5b3-93de39f0e06c"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rechargeable Lantern", new Guid("f1592f94-4b9b-4515-90c4-31ef858dfcfa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Category", "CreatedAt", "Name", "ProductDetailsId", "UpdatedAt" },
                values: new object[] { new Guid("deb46b24-6a60-4f9a-90f7-6f9d3314cb60"), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Headphone", new Guid("0d034c9b-8e63-4838-af27-b13be57d1457"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_User_AddressId",
                table: "User",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductDetailsId",
                table: "Product",
                column: "ProductDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_PriceOffer_ProductId",
                table: "PriceOffer",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_Product_ProductId",
                table: "Cart",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_StoreProduct_ProductDetailsId",
                table: "Product",
                column: "ProductDetailsId",
                principalTable: "StoreProduct",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_Product_ProductId",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_StoreProduct_ProductDetailsId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Address_AddressId",
                table: "User");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "PriceOffer");

            migrationBuilder.DropIndex(
                name: "IX_User_AddressId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Product_ProductDetailsId",
                table: "Product");

            migrationBuilder.DeleteData(
                table: "Buyer",
                keyColumn: "Id",
                keyValue: new Guid("2dc01af8-ffc3-4468-b80d-38d6fef11b34"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("26b7667c-90c9-47b5-a722-3182fb32d599"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b7dffa97-da56-4cbb-b5b3-93de39f0e06c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("deb46b24-6a60-4f9a-90f7-6f9d3314cb60"));

            migrationBuilder.DeleteData(
                table: "StoreProduct",
                keyColumn: "Id",
                keyValue: new Guid("0d034c9b-8e63-4838-af27-b13be57d1457"));

            migrationBuilder.DeleteData(
                table: "StoreProduct",
                keyColumn: "Id",
                keyValue: new Guid("dbca4d53-cbff-4847-8ada-859eca4f7b93"));

            migrationBuilder.DeleteData(
                table: "StoreProduct",
                keyColumn: "Id",
                keyValue: new Guid("f1592f94-4b9b-4515-90c4-31ef858dfcfa"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"));

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: new Guid("1a859ecc-f1cd-422e-9130-bb73d68f86d9"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("315947fe-0a5b-4f4d-bb3d-688306b475ab"));

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ProductDetailsId",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Cart",
                newName: "StoreProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Cart_ProductId",
                table: "Cart",
                newName: "IX_Cart_StoreProductId");

            migrationBuilder.AlterColumn<string>(
                name: "ReferralCode",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OtherName",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageURL",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "StoreProduct",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StoreProduct_ProductId",
                table: "StoreProduct",
                column: "ProductId");

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
        }
    }
}
