using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XCompany_api.Migrations
{
    public partial class ModelRevisions11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "IdentityUserRoles",
                newName: "NormalizedName");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "IdentityUserRoles",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "IdentityUserRoles",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "IdentityUserRoles",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityUserRoles",
                table: "IdentityUserRoles",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityUserRoles",
                table: "IdentityUserRoles");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "IdentityUserRoles");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "IdentityUserRoles");

            migrationBuilder.RenameColumn(
                name: "NormalizedName",
                table: "IdentityUserRoles",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "IdentityUserRoles",
                newName: "RoleId");
        }
    }
}
