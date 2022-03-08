using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XCompany_api.Migrations
{
    public partial class ModelRevisions19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MonthlyPlans_ItemQuantities_itemQuantityId",
                table: "MonthlyPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_WeeklyPlans_ItemQuantities_itemQuantityId",
                table: "WeeklyPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_YearlyPlans_ItemQuantities_itemQuantityId",
                table: "YearlyPlans");

            migrationBuilder.DropIndex(
                name: "IX_YearlyPlans_itemQuantityId",
                table: "YearlyPlans");

            migrationBuilder.DropIndex(
                name: "IX_WeeklyPlans_itemQuantityId",
                table: "WeeklyPlans");

            migrationBuilder.DropIndex(
                name: "IX_MonthlyPlans_itemQuantityId",
                table: "MonthlyPlans");

            migrationBuilder.DropColumn(
                name: "itemQuantityId",
                table: "YearlyPlans");

            migrationBuilder.DropColumn(
                name: "itemQuantityId",
                table: "WeeklyPlans");

            migrationBuilder.DropColumn(
                name: "itemQuantityId",
                table: "MonthlyPlans");

            migrationBuilder.AddColumn<int>(
                name: "MonthlyPlanMonth",
                table: "ItemQuantities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MonthlyPlanYear",
                table: "ItemQuantities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WeeklyPlanid",
                table: "ItemQuantities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "YearlyPlanid",
                table: "ItemQuantities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemQuantities_MonthlyPlanYear_MonthlyPlanMonth",
                table: "ItemQuantities",
                columns: new[] { "MonthlyPlanYear", "MonthlyPlanMonth" });

            migrationBuilder.CreateIndex(
                name: "IX_ItemQuantities_WeeklyPlanid",
                table: "ItemQuantities",
                column: "WeeklyPlanid");

            migrationBuilder.CreateIndex(
                name: "IX_ItemQuantities_YearlyPlanid",
                table: "ItemQuantities",
                column: "YearlyPlanid");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemQuantities_MonthlyPlans_MonthlyPlanYear_MonthlyPlanMonth",
                table: "ItemQuantities",
                columns: new[] { "MonthlyPlanYear", "MonthlyPlanMonth" },
                principalTable: "MonthlyPlans",
                principalColumns: new[] { "Year", "Month" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemQuantities_MonthlyPlans_MonthlyPlanYear_MonthlyPlanMonth",
                table: "ItemQuantities");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemQuantities_WeeklyPlans_WeeklyPlanid",
                table: "ItemQuantities");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemQuantities_YearlyPlans_YearlyPlanid",
                table: "ItemQuantities");

            migrationBuilder.DropIndex(
                name: "IX_ItemQuantities_MonthlyPlanYear_MonthlyPlanMonth",
                table: "ItemQuantities");

            migrationBuilder.DropIndex(
                name: "IX_ItemQuantities_WeeklyPlanid",
                table: "ItemQuantities");

            migrationBuilder.DropIndex(
                name: "IX_ItemQuantities_YearlyPlanid",
                table: "ItemQuantities");

            migrationBuilder.DropColumn(
                name: "MonthlyPlanMonth",
                table: "ItemQuantities");

            migrationBuilder.DropColumn(
                name: "MonthlyPlanYear",
                table: "ItemQuantities");

            migrationBuilder.DropColumn(
                name: "WeeklyPlanid",
                table: "ItemQuantities");

            migrationBuilder.DropColumn(
                name: "YearlyPlanid",
                table: "ItemQuantities");

            migrationBuilder.AddColumn<int>(
                name: "itemQuantityId",
                table: "YearlyPlans",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "itemQuantityId",
                table: "WeeklyPlans",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "itemQuantityId",
                table: "MonthlyPlans",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_YearlyPlans_itemQuantityId",
                table: "YearlyPlans",
                column: "itemQuantityId");

            migrationBuilder.CreateIndex(
                name: "IX_WeeklyPlans_itemQuantityId",
                table: "WeeklyPlans",
                column: "itemQuantityId");

            migrationBuilder.CreateIndex(
                name: "IX_MonthlyPlans_itemQuantityId",
                table: "MonthlyPlans",
                column: "itemQuantityId");

            migrationBuilder.AddForeignKey(
                name: "FK_MonthlyPlans_ItemQuantities_itemQuantityId",
                table: "MonthlyPlans",
                column: "itemQuantityId",
                principalTable: "ItemQuantities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WeeklyPlans_ItemQuantities_itemQuantityId",
                table: "WeeklyPlans",
                column: "itemQuantityId",
                principalTable: "ItemQuantities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_YearlyPlans_ItemQuantities_itemQuantityId",
                table: "YearlyPlans",
                column: "itemQuantityId",
                principalTable: "ItemQuantities",
                principalColumn: "Id");
        }
    }
}
