using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APBD_10_s21147.Migrations
{
    /// <inheritdoc />
    public partial class mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Roles_RoleId",
                table: "Accounts");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "Accounts",
                newName: "FK_role");

            migrationBuilder.RenameIndex(
                name: "IX_Accounts_RoleId",
                table: "Accounts",
                newName: "IX_Accounts_FK_role");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Roles_FK_role",
                table: "Accounts",
                column: "FK_role",
                principalTable: "Roles",
                principalColumn: "PK_role",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Roles_FK_role",
                table: "Accounts");

            migrationBuilder.RenameColumn(
                name: "FK_role",
                table: "Accounts",
                newName: "RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Accounts_FK_role",
                table: "Accounts",
                newName: "IX_Accounts_RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Roles_RoleId",
                table: "Accounts",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "PK_role",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
