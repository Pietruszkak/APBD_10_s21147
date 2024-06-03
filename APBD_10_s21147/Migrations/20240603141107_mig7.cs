using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APBD_10_s21147.Migrations
{
    /// <inheritdoc />
    public partial class mig7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductsCategories_Categories_CategoryId",
                table: "ProductsCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsCategories_Products_ProductId",
                table: "ProductsCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_Accounts_AccountId",
                table: "ShoppingCarts");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_Products_ProductId",
                table: "ShoppingCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCarts",
                table: "ShoppingCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductsCategories",
                table: "ProductsCategories");

            migrationBuilder.RenameTable(
                name: "ShoppingCarts",
                newName: "Shopping_Carts");

            migrationBuilder.RenameTable(
                name: "ProductsCategories",
                newName: "Products_Categories");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCarts_ProductId",
                table: "Shopping_Carts",
                newName: "IX_Shopping_Carts_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductsCategories_CategoryId",
                table: "Products_Categories",
                newName: "IX_Products_Categories_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shopping_Carts",
                table: "Shopping_Carts",
                columns: new[] { "AccountId", "ProductId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products_Categories",
                table: "Products_Categories",
                columns: new[] { "ProductId", "CategoryId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_Categories_CategoryId",
                table: "Products_Categories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "PK_category",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_Products_ProductId",
                table: "Products_Categories",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "PK_account",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shopping_Carts_Accounts_AccountId",
                table: "Shopping_Carts",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "PK_account",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shopping_Carts_Products_ProductId",
                table: "Shopping_Carts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "PK_account",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_Categories_CategoryId",
                table: "Products_Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_Products_ProductId",
                table: "Products_Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Shopping_Carts_Accounts_AccountId",
                table: "Shopping_Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Shopping_Carts_Products_ProductId",
                table: "Shopping_Carts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shopping_Carts",
                table: "Shopping_Carts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products_Categories",
                table: "Products_Categories");

            migrationBuilder.RenameTable(
                name: "Shopping_Carts",
                newName: "ShoppingCarts");

            migrationBuilder.RenameTable(
                name: "Products_Categories",
                newName: "ProductsCategories");

            migrationBuilder.RenameIndex(
                name: "IX_Shopping_Carts_ProductId",
                table: "ShoppingCarts",
                newName: "IX_ShoppingCarts_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_Categories_CategoryId",
                table: "ProductsCategories",
                newName: "IX_ProductsCategories_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCarts",
                table: "ShoppingCarts",
                columns: new[] { "AccountId", "ProductId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductsCategories",
                table: "ProductsCategories",
                columns: new[] { "ProductId", "CategoryId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsCategories_Categories_CategoryId",
                table: "ProductsCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "PK_category",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsCategories_Products_ProductId",
                table: "ProductsCategories",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "PK_account",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_Accounts_AccountId",
                table: "ShoppingCarts",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "PK_account",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_Products_ProductId",
                table: "ShoppingCarts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "PK_account",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
