using Microsoft.EntityFrameworkCore.Migrations;

namespace MyBudget.Migrations
{
    public partial class AddFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdentityUserID",
                table: "incomes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserID",
                table: "Budgets",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_incomes_IdentityUserID",
                table: "incomes",
                column: "IdentityUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Budgets_IdentityUserID",
                table: "Budgets",
                column: "IdentityUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Budgets_AspNetUsers_IdentityUserID",
                table: "Budgets",
                column: "IdentityUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_incomes_AspNetUsers_IdentityUserID",
                table: "incomes",
                column: "IdentityUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Budgets_AspNetUsers_IdentityUserID",
                table: "Budgets");

            migrationBuilder.DropForeignKey(
                name: "FK_incomes_AspNetUsers_IdentityUserID",
                table: "incomes");

            migrationBuilder.DropIndex(
                name: "IX_incomes_IdentityUserID",
                table: "incomes");

            migrationBuilder.DropIndex(
                name: "IX_Budgets_IdentityUserID",
                table: "Budgets");

            migrationBuilder.DropColumn(
                name: "IdentityUserID",
                table: "incomes");

            migrationBuilder.DropColumn(
                name: "IdentityUserID",
                table: "Budgets");
        }
    }
}
