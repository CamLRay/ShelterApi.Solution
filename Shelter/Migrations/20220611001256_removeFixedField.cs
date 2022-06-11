using Microsoft.EntityFrameworkCore.Migrations;

namespace Shelter.Migrations
{
    public partial class removeFixedField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Fixed",
                table: "Animals",
                newName: "Spayed");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Spayed",
                table: "Animals",
                newName: "Fixed");
        }
    }
}
