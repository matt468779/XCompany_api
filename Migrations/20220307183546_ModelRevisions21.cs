using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XCompany_api.Migrations
{
    public partial class ModelRevisions21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemQuantities_WeeklyPlans_WeeklyPlanid",
                table: "ItemQuantities");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemQuantities_YearlyPlans_YearlyPlanid",
                table: "ItemQuantities");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "YearlyPlans",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "WeeklyPlans",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "MonthlyPlans",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "YearlyPlanid",
                table: "ItemQuantities",
                newName: "YearlyPlanId");

            migrationBuilder.RenameColumn(
                name: "WeeklyPlanid",
                table: "ItemQuantities",
                newName: "WeeklyPlanId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemQuantities_YearlyPlanid",
                table: "ItemQuantities",
                newName: "IX_ItemQuantities_YearlyPlanId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemQuantities_WeeklyPlanid",
                table: "ItemQuantities",
                newName: "IX_ItemQuantities_WeeklyPlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemQuantities_WeeklyPlans_WeeklyPlanId",
                table: "ItemQuantities",
                column: "WeeklyPlanId",
                principalTable: "WeeklyPlans",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemQuantities_YearlyPlans_YearlyPlanId",
                table: "ItemQuantities",
                column: "YearlyPlanId",
                principalTable: "YearlyPlans",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemQuantities_WeeklyPlans_WeeklyPlanId",
                table: "ItemQuantities");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemQuantities_YearlyPlans_YearlyPlanId",
                table: "ItemQuantities");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "YearlyPlans",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "WeeklyPlans",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "MonthlyPlans",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "YearlyPlanId",
                table: "ItemQuantities",
                newName: "YearlyPlanid");

            migrationBuilder.RenameColumn(
                name: "WeeklyPlanId",
                table: "ItemQuantities",
                newName: "WeeklyPlanid");

            migrationBuilder.RenameIndex(
                name: "IX_ItemQuantities_YearlyPlanId",
                table: "ItemQuantities",
                newName: "IX_ItemQuantities_YearlyPlanid");

            migrationBuilder.RenameIndex(
                name: "IX_ItemQuantities_WeeklyPlanId",
                table: "ItemQuantities",
                newName: "IX_ItemQuantities_WeeklyPlanid");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemQuantities_WeeklyPlans_WeeklyPlanid",
                table: "ItemQuantities",
                column: "WeeklyPlanid",
                principalTable: "WeeklyPlans",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemQuantities_YearlyPlans_YearlyPlanid",
                table: "ItemQuantities",
                column: "YearlyPlanid",
                principalTable: "YearlyPlans",
                principalColumn: "id");
        }
    }
}
