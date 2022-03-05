using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XCompany_api.Migrations
{
    public partial class ModelRevisions7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_ItemQuantities_ItemQuantityId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_ItemQuantityId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "ItemQuantityId",
                table: "Sales");

            migrationBuilder.AddColumn<int>(
                name: "SaleId",
                table: "ItemQuantities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemQuantities_SaleId",
                table: "ItemQuantities",
                column: "SaleId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemQuantities_Sales_SaleId",
                table: "ItemQuantities",
                column: "SaleId",
                principalTable: "Sales",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemQuantities_Sales_SaleId",
                table: "ItemQuantities");

            migrationBuilder.DropIndex(
                name: "IX_ItemQuantities_SaleId",
                table: "ItemQuantities");

            migrationBuilder.DropColumn(
                name: "SaleId",
                table: "ItemQuantities");

            migrationBuilder.AddColumn<int>(
                name: "ItemQuantityId",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ItemQuantityId",
                table: "Sales",
                column: "ItemQuantityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_ItemQuantities_ItemQuantityId",
                table: "Sales",
                column: "ItemQuantityId",
                principalTable: "ItemQuantities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
