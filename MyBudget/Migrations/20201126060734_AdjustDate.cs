using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyBudget.Migrations
{
    public partial class AdjustDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "IncomeMonth",
                table: "incomes",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Month",
                table: "Budgets",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "BudgetID",
                keyValue: 1,
                column: "Month",
                value: new DateTime(2020, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "BudgetID",
                keyValue: 2,
                column: "Month",
                value: new DateTime(2020, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "BudgetID",
                keyValue: 3,
                column: "Month",
                value: new DateTime(2020, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "incomes",
                keyColumn: "IncomeID",
                keyValue: 5,
                column: "IncomeMonth",
                value: new DateTime(2020, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "incomes",
                keyColumn: "IncomeID",
                keyValue: 6,
                column: "IncomeMonth",
                value: new DateTime(2020, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "incomes",
                keyColumn: "IncomeID",
                keyValue: 7,
                column: "IncomeMonth",
                value: new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IncomeMonth",
                table: "incomes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "Month",
                table: "Budgets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "BudgetID",
                keyValue: 1,
                column: "Month",
                value: "2020/10/08");

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "BudgetID",
                keyValue: 2,
                column: "Month",
                value: "2020/11/09");

            migrationBuilder.UpdateData(
                table: "Budgets",
                keyColumn: "BudgetID",
                keyValue: 3,
                column: "Month",
                value: "2020/11/09");

            migrationBuilder.UpdateData(
                table: "incomes",
                keyColumn: "IncomeID",
                keyValue: 5,
                column: "IncomeMonth",
                value: "2020/10/08");

            migrationBuilder.UpdateData(
                table: "incomes",
                keyColumn: "IncomeID",
                keyValue: 6,
                column: "IncomeMonth",
                value: "2020/10/08");

            migrationBuilder.UpdateData(
                table: "incomes",
                keyColumn: "IncomeID",
                keyValue: 7,
                column: "IncomeMonth",
                value: "2020/10/08");
        }
    }
}
