using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XCompany_api.Migrations
{
    public partial class ModelRevisions2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeMonthlyPlans_MonthlyPlans_MonthlyPlanid",
                table: "EmployeeMonthlyPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeYearlyPlans_YearlyPlans_YearlyPlanid",
                table: "EmployeeYearlyPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_MonthlyPlans_YearlyPlans_YearlyPlanid",
                table: "MonthlyPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_WeeklyPlans_MonthlyPlans_MonthlyPlanid",
                table: "WeeklyPlans");

            migrationBuilder.DropIndex(
                name: "IX_WeeklyPlans_MonthlyPlanid",
                table: "WeeklyPlans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MonthlyPlans",
                table: "MonthlyPlans");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeMonthlyPlans_MonthlyPlanid",
                table: "EmployeeMonthlyPlans");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "YearlyPlans");

            migrationBuilder.DropColumn(
                name: "id",
                table: "MonthlyPlans");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "YearlyPlans",
                newName: "YearId");

            migrationBuilder.RenameColumn(
                name: "MonthlyPlanid",
                table: "WeeklyPlans",
                newName: "MonthlyPlanYear");

            migrationBuilder.RenameColumn(
                name: "YearlyPlanid",
                table: "MonthlyPlans",
                newName: "YearlyPlanYearId");

            migrationBuilder.RenameIndex(
                name: "IX_MonthlyPlans_YearlyPlanid",
                table: "MonthlyPlans",
                newName: "IX_MonthlyPlans_YearlyPlanYearId");

            migrationBuilder.RenameColumn(
                name: "YearlyPlanid",
                table: "EmployeeYearlyPlans",
                newName: "YearlyPlanYearId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeYearlyPlans_YearlyPlanid",
                table: "EmployeeYearlyPlans",
                newName: "IX_EmployeeYearlyPlans_YearlyPlanYearId");

            migrationBuilder.RenameColumn(
                name: "MonthlyPlanid",
                table: "EmployeeMonthlyPlans",
                newName: "MonthlyPlanYear");

            migrationBuilder.AddColumn<int>(
                name: "MonthlyPlanMonth",
                table: "WeeklyPlans",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Year",
                table: "MonthlyPlans",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Month",
                table: "MonthlyPlans",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MonthlyPlanMonth",
                table: "EmployeeMonthlyPlans",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MonthlyPlans",
                table: "MonthlyPlans",
                columns: new[] { "Year", "Month" });

            migrationBuilder.CreateIndex(
                name: "IX_WeeklyPlans_MonthlyPlanYear_MonthlyPlanMonth",
                table: "WeeklyPlans",
                columns: new[] { "MonthlyPlanYear", "MonthlyPlanMonth" });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeMonthlyPlans_MonthlyPlanYear_MonthlyPlanMonth",
                table: "EmployeeMonthlyPlans",
                columns: new[] { "MonthlyPlanYear", "MonthlyPlanMonth" });

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeMonthlyPlans_MonthlyPlans_MonthlyPlanYear_MonthlyPla~",
                table: "EmployeeMonthlyPlans",
                columns: new[] { "MonthlyPlanYear", "MonthlyPlanMonth" },
                principalTable: "MonthlyPlans",
                principalColumns: new[] { "Year", "Month" });

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeYearlyPlans_YearlyPlans_YearlyPlanYearId",
                table: "EmployeeYearlyPlans",
                column: "YearlyPlanYearId",
                principalTable: "YearlyPlans",
                principalColumn: "YearId");

            migrationBuilder.AddForeignKey(
                name: "FK_MonthlyPlans_YearlyPlans_YearlyPlanYearId",
                table: "MonthlyPlans",
                column: "YearlyPlanYearId",
                principalTable: "YearlyPlans",
                principalColumn: "YearId");

            migrationBuilder.AddForeignKey(
                name: "FK_WeeklyPlans_MonthlyPlans_MonthlyPlanYear_MonthlyPlanMonth",
                table: "WeeklyPlans",
                columns: new[] { "MonthlyPlanYear", "MonthlyPlanMonth" },
                principalTable: "MonthlyPlans",
                principalColumns: new[] { "Year", "Month" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeMonthlyPlans_MonthlyPlans_MonthlyPlanYear_MonthlyPla~",
                table: "EmployeeMonthlyPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeYearlyPlans_YearlyPlans_YearlyPlanYearId",
                table: "EmployeeYearlyPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_MonthlyPlans_YearlyPlans_YearlyPlanYearId",
                table: "MonthlyPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_WeeklyPlans_MonthlyPlans_MonthlyPlanYear_MonthlyPlanMonth",
                table: "WeeklyPlans");

            migrationBuilder.DropIndex(
                name: "IX_WeeklyPlans_MonthlyPlanYear_MonthlyPlanMonth",
                table: "WeeklyPlans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MonthlyPlans",
                table: "MonthlyPlans");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeMonthlyPlans_MonthlyPlanYear_MonthlyPlanMonth",
                table: "EmployeeMonthlyPlans");

            migrationBuilder.DropColumn(
                name: "MonthlyPlanMonth",
                table: "WeeklyPlans");

            migrationBuilder.DropColumn(
                name: "MonthlyPlanMonth",
                table: "EmployeeMonthlyPlans");

            migrationBuilder.RenameColumn(
                name: "YearId",
                table: "YearlyPlans",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "MonthlyPlanYear",
                table: "WeeklyPlans",
                newName: "MonthlyPlanid");

            migrationBuilder.RenameColumn(
                name: "YearlyPlanYearId",
                table: "MonthlyPlans",
                newName: "YearlyPlanid");

            migrationBuilder.RenameIndex(
                name: "IX_MonthlyPlans_YearlyPlanYearId",
                table: "MonthlyPlans",
                newName: "IX_MonthlyPlans_YearlyPlanid");

            migrationBuilder.RenameColumn(
                name: "YearlyPlanYearId",
                table: "EmployeeYearlyPlans",
                newName: "YearlyPlanid");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeYearlyPlans_YearlyPlanYearId",
                table: "EmployeeYearlyPlans",
                newName: "IX_EmployeeYearlyPlans_YearlyPlanid");

            migrationBuilder.RenameColumn(
                name: "MonthlyPlanYear",
                table: "EmployeeMonthlyPlans",
                newName: "MonthlyPlanid");

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "YearlyPlans",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Month",
                table: "MonthlyPlans",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Year",
                table: "MonthlyPlans",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "MonthlyPlans",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MonthlyPlans",
                table: "MonthlyPlans",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_WeeklyPlans_MonthlyPlanid",
                table: "WeeklyPlans",
                column: "MonthlyPlanid");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeMonthlyPlans_MonthlyPlanid",
                table: "EmployeeMonthlyPlans",
                column: "MonthlyPlanid");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeMonthlyPlans_MonthlyPlans_MonthlyPlanid",
                table: "EmployeeMonthlyPlans",
                column: "MonthlyPlanid",
                principalTable: "MonthlyPlans",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeYearlyPlans_YearlyPlans_YearlyPlanid",
                table: "EmployeeYearlyPlans",
                column: "YearlyPlanid",
                principalTable: "YearlyPlans",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_MonthlyPlans_YearlyPlans_YearlyPlanid",
                table: "MonthlyPlans",
                column: "YearlyPlanid",
                principalTable: "YearlyPlans",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_WeeklyPlans_MonthlyPlans_MonthlyPlanid",
                table: "WeeklyPlans",
                column: "MonthlyPlanid",
                principalTable: "MonthlyPlans",
                principalColumn: "id");
        }
    }
}
