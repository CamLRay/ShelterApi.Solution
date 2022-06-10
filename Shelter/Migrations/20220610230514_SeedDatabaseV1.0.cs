using Microsoft.EntityFrameworkCore.Migrations;

namespace Shelter.Migrations
{
    public partial class SeedDatabaseV10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "About", "Age", "Aggression", "Breed", "Fee", "Fixed", "Gender", "HouseTrained", "Image", "Name", "Species", "Vaccinated" },
                values: new object[] { 3, "Frank (Frankey) – is our resident clown and a favorite of many of the staff; there isn’t a photo that completely captures all of his personality. He is a happy, gregarious 2ish little pitty ready to be someone’s best friend and partner.", 28, "friendly", "Pitbull Terrier", 300, true, "Male", true, "https://4152bg3zv88l2xvzsx4fs0md-wpengine.netdna-ssl.com/wp-content/uploads/2022/03/Frank-2-700x700.jpg", "Frank", "Dog", true });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "About", "Age", "Aggression", "Breed", "Fee", "Fixed", "Gender", "HouseTrained", "Image", "Name", "Species", "Vaccinated" },
                values: new object[] { 4, "If you are interested in meeting me, please email Newberg Animal Shelter at frontdesk@newberganimals.com", 4, "good with dogs", "Shar Pei Mix", 600, true, "Female", false, "https://4152bg3zv88l2xvzsx4fs0md-wpengine.netdna-ssl.com/wp-content/uploads/2022/06/cherry3-700x933.jpeg", "Cherry", "Dog", true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);
        }
    }
}
