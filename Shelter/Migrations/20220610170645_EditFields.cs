using Microsoft.EntityFrameworkCore.Migrations;

namespace Shelter.Migrations
{
    public partial class EditFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Vacinated",
                table: "Animals",
                newName: "Vaccinated");

            migrationBuilder.RenameColumn(
                name: "Agression",
                table: "Animals",
                newName: "Aggression");

            migrationBuilder.AddColumn<int>(
                name: "Fee",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fee",
                table: "Animals");

            migrationBuilder.RenameColumn(
                name: "Vaccinated",
                table: "Animals",
                newName: "Vacinated");

            migrationBuilder.RenameColumn(
                name: "Aggression",
                table: "Animals",
                newName: "Agression");
        }
    }
}
