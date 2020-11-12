using Microsoft.EntityFrameworkCore.Migrations;

namespace MyBudget.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Rating = table.Column<int>(nullable: false)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
