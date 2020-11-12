using Microsoft.EntityFrameworkCore.Migrations;

namespace MyBudget.Migrations
{
    public partial class Incomes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "incomes",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "incomes",
                keyColumn: "IncomeID",
                keyValue: 5,
                column: "UserId",
                value: "jfkfljaklf");

            migrationBuilder.UpdateData(
                table: "incomes",
                keyColumn: "IncomeID",
                keyValue: 6,
                column: "UserId",
                value: "jfkfljaklf");

            migrationBuilder.UpdateData(
                table: "incomes",
                keyColumn: "IncomeID",
                keyValue: 7,
                column: "UserId",
                value: "jfkfljaklf");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "incomes");
        }
    }
}
