
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyBudget.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "incomes",
                columns: table => new
                {
                    IncomeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncomeSource = table.Column<string>(nullable: false),
                    Amount = table.Column<float>(nullable: false),
                    IncomeMonth = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_incomes", x => x.IncomeID);
                });

            migrationBuilder.InsertData(
                table: "incomes",
                columns: new[] { "IncomeID", "Amount", "IncomeMonth", "IncomeSource" },
                values: new object[] { 5, 2000f, "2020/10/08", "Salary" });

            migrationBuilder.InsertData(
                table: "incomes",
                columns: new[] { "IncomeID", "Amount", "IncomeMonth", "IncomeSource" },
                values: new object[] { 6, 1000f, "2020/10/08", "Rent out house" });

            migrationBuilder.InsertData(
                table: "incomes",
                columns: new[] { "IncomeID", "Amount", "IncomeMonth", "IncomeSource" },
                values: new object[] { 7, 600f, "2020/10/08", "Stock divided" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "incomes");
        }
    }
}
