using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XCompany_api.Migrations
{
    public partial class ModelRevisions9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeMonthlyPlans_Employees_EmployeeId",
                table: "EmployeeMonthlyPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeMonthlyPlans_MonthlyPlans_MonthlyPlanYear_MonthlyPla~",
                table: "EmployeeMonthlyPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Offices_OfficeId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Units_UnitId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeWeeklyPlans_Employees_EmployeeId",
                table: "EmployeeWeeklyPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeWeeklyPlans_WeeklyPlans_WeeklyPlanid",
                table: "EmployeeWeeklyPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeYearlyPlans_Employees_EmployeeId",
                table: "EmployeeYearlyPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeYearlyPlans_YearlyPlans_YearlyPlanYearId",
                table: "EmployeeYearlyPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemQuantities_Items_ItemId",
                table: "ItemQuantities");

            migrationBuilder.DropIndex(
                name: "IX_ItemQuantities_ItemId",
                table: "ItemQuantities");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeYearlyPlans_EmployeeId",
                table: "EmployeeYearlyPlans");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeYearlyPlans_YearlyPlanYearId",
                table: "EmployeeYearlyPlans");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeWeeklyPlans_EmployeeId",
                table: "EmployeeWeeklyPlans");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeWeeklyPlans_WeeklyPlanid",
                table: "EmployeeWeeklyPlans");

            migrationBuilder.DropIndex(
                name: "IX_Employees_OfficeId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_UnitId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeMonthlyPlans_EmployeeId",
                table: "EmployeeMonthlyPlans");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeMonthlyPlans_MonthlyPlanYear_MonthlyPlanMonth",
                table: "EmployeeMonthlyPlans");

            migrationBuilder.DropColumn(
                name: "MonthlyPlanMonth",
                table: "EmployeeMonthlyPlans");

            migrationBuilder.RenameColumn(
                name: "YearlyPlanYearId",
                table: "EmployeeYearlyPlans",
                newName: "YearlyPlanId");

            migrationBuilder.RenameColumn(
                name: "WeeklyPlanid",
                table: "EmployeeWeeklyPlans",
                newName: "WeeklyPlanId");

            migrationBuilder.RenameColumn(
                name: "UnitId",
                table: "Employees",
                newName: "Unit");

            migrationBuilder.RenameColumn(
                name: "MonthlyPlanYear",
                table: "EmployeeMonthlyPlans",
                newName: "MonthlyPlanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "YearlyPlanId",
                table: "EmployeeYearlyPlans",
                newName: "YearlyPlanYearId");

            migrationBuilder.RenameColumn(
                name: "WeeklyPlanId",
                table: "EmployeeWeeklyPlans",
                newName: "WeeklyPlanid");

            migrationBuilder.RenameColumn(
                name: "Unit",
                table: "Employees",
                newName: "UnitId");

            migrationBuilder.RenameColumn(
                name: "MonthlyPlanId",
                table: "EmployeeMonthlyPlans",
                newName: "MonthlyPlanYear");

            migrationBuilder.AddColumn<int>(
                name: "MonthlyPlanMonth",
                table: "EmployeeMonthlyPlans",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemQuantities_ItemId",
                table: "ItemQuantities",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeYearlyPlans_EmployeeId",
                table: "EmployeeYearlyPlans",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeYearlyPlans_YearlyPlanYearId",
                table: "EmployeeYearlyPlans",
                column: "YearlyPlanYearId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeWeeklyPlans_EmployeeId",
                table: "EmployeeWeeklyPlans",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeWeeklyPlans_WeeklyPlanid",
                table: "EmployeeWeeklyPlans",
                column: "WeeklyPlanid");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_OfficeId",
                table: "Employees",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UnitId",
                table: "Employees",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeMonthlyPlans_EmployeeId",
                table: "EmployeeMonthlyPlans",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeMonthlyPlans_MonthlyPlanYear_MonthlyPlanMonth",
                table: "EmployeeMonthlyPlans",
                columns: new[] { "MonthlyPlanYear", "MonthlyPlanMonth" });

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeMonthlyPlans_Employees_EmployeeId",
                table: "EmployeeMonthlyPlans",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeMonthlyPlans_MonthlyPlans_MonthlyPlanYear_MonthlyPla~",
                table: "EmployeeMonthlyPlans",
                columns: new[] { "MonthlyPlanYear", "MonthlyPlanMonth" },
                principalTable: "MonthlyPlans",
                principalColumns: new[] { "Year", "Month" });

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Offices_OfficeId",
                table: "Employees",
                column: "OfficeId",
                principalTable: "Offices",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Units_UnitId",
                table: "Employees",
                column: "UnitId",
                principalTable: "Units",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeWeeklyPlans_Employees_EmployeeId",
                table: "EmployeeWeeklyPlans",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeWeeklyPlans_WeeklyPlans_WeeklyPlanid",
                table: "EmployeeWeeklyPlans",
                column: "WeeklyPlanid",
                principalTable: "WeeklyPlans",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeYearlyPlans_Employees_EmployeeId",
                table: "EmployeeYearlyPlans",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeYearlyPlans_YearlyPlans_YearlyPlanYearId",
                table: "EmployeeYearlyPlans",
                column: "YearlyPlanYearId",
                principalTable: "YearlyPlans",
                principalColumn: "YearId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemQuantities_Items_ItemId",
                table: "ItemQuantities",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id");
        }
    }
}
