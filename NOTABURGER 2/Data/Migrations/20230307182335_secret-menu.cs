using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NOTABURGER_2.Data.Migrations
{
    public partial class secretmenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SecretMenuItems",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soloPrice = table.Column<float>(type: "real", nullable: false),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    includes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    allergens = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imageSrc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecretMenuItems", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SecretMenuItems");
        }
    }
}
