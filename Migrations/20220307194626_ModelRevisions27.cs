using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XCompany_api.Migrations
{
    public partial class ModelRevisions27 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemQuantities_MonthlyPlans_MonthlyPlanYear_MonthlyPlanMonth",
                table: "ItemQuantities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MonthlyPlans",
                table: "MonthlyPlans");

            migrationBuilder.DropIndex(
                name: "IX_ItemQuantities_MonthlyPlanYear_MonthlyPlanMonth",
                table: "ItemQuantities");

            migrationBuilder.DropColumn(
                name: "MonthlyPlanMonth",
                table: "ItemQuantities");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "MonthlyPlans",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "MonthlyPlanYear",
                table: "ItemQuantities",
                newName: "MonthlyPlanId");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "MonthlyPlans",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_MonthlyPlans",
                table: "MonthlyPlans",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemQuantities_MonthlyPlanId",
                table: "ItemQuantities",
                column: "MonthlyPlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemQuantities_MonthlyPlans_MonthlyPlanId",
                table: "ItemQuantities",
                column: "MonthlyPlanId",
                principalTable: "MonthlyPlans",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemQuantities_MonthlyPlans_MonthlyPlanId",
                table: "ItemQuantities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MonthlyPlans",
                table: "MonthlyPlans");

            migrationBuilder.DropIndex(
                name: "IX_ItemQuantities_MonthlyPlanId",
                table: "ItemQuantities");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "MonthlyPlans",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "MonthlyPlanId",
                table: "ItemQuantities",
                newName: "MonthlyPlanYear");

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

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "MonthlyPlans",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "MonthlyPlanMonth",
                table: "ItemQuantities",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MonthlyPlans",
                table: "MonthlyPlans",
                columns: new[] { "Year", "Month" });

            migrationBuilder.CreateIndex(
                name: "IX_ItemQuantities_MonthlyPlanYear_MonthlyPlanMonth",
                table: "ItemQuantities",
                columns: new[] { "MonthlyPlanYear", "MonthlyPlanMonth" });

            migrationBuilder.AddForeignKey(
                name: "FK_ItemQuantities_MonthlyPlans_MonthlyPlanYear_MonthlyPlanMonth",
                table: "ItemQuantities",
                columns: new[] { "MonthlyPlanYear", "MonthlyPlanMonth" },
                principalTable: "MonthlyPlans",
                principalColumns: new[] { "Year", "Month" });
        }
    }
}
