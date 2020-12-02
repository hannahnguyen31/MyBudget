using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyBudget.Migrations
{
    public partial class AddGoalUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Goals",
                columns: table => new
                {
                    GoalID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncomeGoal = table.Column<float>(nullable: false),
                    BudgetGoal = table.Column<float>(nullable: false),
                    SavingGoal = table.Column<float>(nullable: false),
                    GoalMonth = table.Column<DateTime>(nullable: false),
                    IdentityUserID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goals", x => x.GoalID);
                    table.ForeignKey(
                        name: "FK_Goals_AspNetUsers_IdentityUserID",
                        column: x => x.IdentityUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Goals_IdentityUserID",
                table: "Goals",
                column: "IdentityUserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Goals");
        }
    }
}
