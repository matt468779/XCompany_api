using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XCompany_api.Migrations
{
    public partial class ModelRevisions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "WeeklyPlans");

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "WeeklyPlans",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "month",
                table: "WeeklyPlans",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "week",
                table: "WeeklyPlans",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Year",
                table: "WeeklyPlans");

            migrationBuilder.DropColumn(
                name: "month",
                table: "WeeklyPlans");

            migrationBuilder.DropColumn(
                name: "week",
                table: "WeeklyPlans");

            migrationBuilder.AddColumn<DateOnly>(
                name: "Date",
                table: "WeeklyPlans",
                type: "date",
                nullable: true);
        }
    }
}
