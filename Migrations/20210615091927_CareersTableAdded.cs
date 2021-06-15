using Microsoft.EntityFrameworkCore.Migrations;

namespace PsDevs.Migrations
{
    public partial class CareersTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Careers",
                columns: table => new
                {
                    CareerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CareerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CareerDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CareerYearsExperience = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CareerType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Careers", x => x.CareerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Careers");
        }
    }
}
