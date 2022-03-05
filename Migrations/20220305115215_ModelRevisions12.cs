using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XCompany_api.Migrations
{
    public partial class ModelRevisions12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "IdentityRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityRoles");

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
    }
}
