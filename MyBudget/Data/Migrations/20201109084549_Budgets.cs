using Microsoft.EntityFrameworkCore.Migrations;

namespace MyBudget.Data.Migrations
{
    public partial class Budgets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.CreateTable(
                name: "Budgets",
                columns: table => new
                {
                    BudgetID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(nullable: false),
                    Budgeted = table.Column<float>(nullable: false),
                    Activity = table.Column<float>(nullable: false),
                    Available = table.Column<float>(nullable: false),
                    Month = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Budgets", x => x.BudgetID);
                });

            migrationBuilder.InsertData(
                table: "Budgets",
                columns: new[] { "BudgetID", "Activity", "Available", "Budgeted", "Category", "Month" },
                values: new object[] { 1, 2000f, 0f, 2000f, "Mortgate", "2020/10/08" });

            migrationBuilder.InsertData(
                table: "Budgets",
                columns: new[] { "BudgetID", "Activity", "Available", "Budgeted", "Category", "Month" },
                values: new object[] { 2, 800f, 200f, 1000f, "Food", "2020/11/09" });

            migrationBuilder.InsertData(
                table: "Budgets",
                columns: new[] { "BudgetID", "Activity", "Available", "Budgeted", "Category", "Month" },
                values: new object[] { 3, 150f, 50f, 200f, "Utilities", "2020/11/09" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Budgets");

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieID);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieID", "Rating", "Title", "Year" },
                values: new object[] { 1, 8, "Game of Throne", 2019 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieID", "Rating", "Title", "Year" },
                values: new object[] { 2, 10, "The Gof Father", 1972 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieID", "Rating", "Title", "Year" },
                values: new object[] { 3, 7, "Over the Moon", 2020 });
        }
    }
}
