using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NOTABURGER_2.Data.Migrations
{
    public partial class UpdatedRolesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "Roles");
        }
    }
}
