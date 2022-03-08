using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XCompany_api.Migrations
{
    public partial class ModelRevisions18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemQuantities_WeeklyPlans_WeeklyPlanid",
                table: "ItemQuantities");

            migrationBuilder.DropForeignKey(
                name: "FK_MonthlyPlans_YearlyPlans_YearlyPlanYearId",
                table: "MonthlyPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_WeeklyPlans_MonthlyPlans_MonthlyPlanYear_MonthlyPlanMonth",
                table: "WeeklyPlans");

            migrationBuilder.DropIndex(
                name: "IX_WeeklyPlans_MonthlyPlanYear_MonthlyPlanMonth",
                table: "WeeklyPlans");

            migrationBuilder.DropIndex(
                name: "IX_ItemQuantities_WeeklyPlanid",
                table: "ItemQuantities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "MonthlyPlanMonth",
                table: "WeeklyPlans");

            migrationBuilder.DropColumn(
                name: "WeeklyPlanid",
                table: "ItemQuantities");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "EmployeeYearlyPlans");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "EmployeeWeeklyPlans");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "EmployeeMonthlyPlans");

            migrationBuilder.RenameColumn(
                name: "YearId",
                table: "YearlyPlans",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "week",
                table: "WeeklyPlans",
                newName: "Week");

            migrationBuilder.RenameColumn(
                name: "month",
                table: "WeeklyPlans",
                newName: "Month");

            migrationBuilder.RenameColumn(
                name: "MonthlyPlanYear",
                table: "WeeklyPlans",
                newName: "itemQuantityId");

            migrationBuilder.RenameColumn(
                name: "YearlyPlanYearId",
                table: "MonthlyPlans",
                newName: "itemQuantityId");

            migrationBuilder.RenameIndex(
                name: "IX_MonthlyPlans_YearlyPlanYearId",
                table: "MonthlyPlans",
                newName: "IX_MonthlyPlans_itemQuantityId");

            migrationBuilder.AddColumn<int>(
                name: "Customers",
                table: "YearlyPlans",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Total",
                table: "YearlyPlans",
                type: "double",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "YearlyPlans",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "itemQuantityId",
                table: "YearlyPlans",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Customers",
                table: "MonthlyPlans",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Total",
                table: "MonthlyPlans",
                type: "double",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "MonthlyPlans",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "EmployeeYearlyPlans",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "EmployeeWeeklyPlans",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Username",
                keyValue: null,
                column: "Username",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Employees",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "EmployeeMonthlyPlans",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Username");

            migrationBuilder.CreateIndex(
                name: "IX_YearlyPlans_itemQuantityId",
                table: "YearlyPlans",
                column: "itemQuantityId");

            migrationBuilder.CreateIndex(
                name: "IX_WeeklyPlans_itemQuantityId",
                table: "WeeklyPlans",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Customers",
                table: "YearlyPlans");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "YearlyPlans");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "YearlyPlans");

            migrationBuilder.DropColumn(
                name: "itemQuantityId",
                table: "YearlyPlans");

            migrationBuilder.DropColumn(
                name: "Customers",
                table: "MonthlyPlans");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "MonthlyPlans");

            migrationBuilder.DropColumn(
                name: "id",
                table: "MonthlyPlans");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "EmployeeYearlyPlans");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "EmployeeWeeklyPlans");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "EmployeeMonthlyPlans");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "YearlyPlans",
                newName: "YearId");

            migrationBuilder.RenameColumn(
                name: "Week",
                table: "WeeklyPlans",
                newName: "week");

            migrationBuilder.RenameColumn(
                name: "Month",
                table: "WeeklyPlans",
                newName: "month");

            migrationBuilder.RenameColumn(
                name: "itemQuantityId",
                table: "WeeklyPlans",
                newName: "MonthlyPlanYear");

            migrationBuilder.RenameColumn(
                name: "itemQuantityId",
                table: "MonthlyPlans",
                newName: "YearlyPlanYearId");

            migrationBuilder.RenameIndex(
                name: "IX_MonthlyPlans_itemQuantityId",
                table: "MonthlyPlans",
                newName: "IX_MonthlyPlans_YearlyPlanYearId");

            migrationBuilder.AddColumn<int>(
                name: "MonthlyPlanMonth",
                table: "WeeklyPlans",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WeeklyPlanid",
                table: "ItemQuantities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "EmployeeYearlyPlans",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "EmployeeWeeklyPlans",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Employees",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "EmployeeMonthlyPlans",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_WeeklyPlans_MonthlyPlanYear_MonthlyPlanMonth",
                table: "WeeklyPlans",
                columns: new[] { "MonthlyPlanYear", "MonthlyPlanMonth" });

            migrationBuilder.CreateIndex(
                name: "IX_ItemQuantities_WeeklyPlanid",
                table: "ItemQuantities",
                column: "WeeklyPlanid");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemQuantities_WeeklyPlans_WeeklyPlanid",
                table: "ItemQuantities",
                column: "WeeklyPlanid",
                principalTable: "WeeklyPlans",
                principalColumn: "id");

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
    }
}
