using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddDescriptionAndImageUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Equipment",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Equipment",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "Name",
                keyValue: "Diamond Chestplate",
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Covers the upper body of the player.", "/images/equipment/chest/diamond_chestplate.png" });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "Name",
                keyValue: "Fancy Hat",
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "A cheap basic hat which makes you go a little faster.", "/images/equipment/head/golden_helmet.png" });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "Name",
                keyValue: "Pumpkin",
                columns: new[] { "Agility", "Description", "ImageUrl", "Strength" },
                values: new object[] { -50, "A creepy pumpkin to scare others.", "/images/equipment/head/carved_pumpkin.png", 25 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Equipment");

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "Name",
                keyValue: "Pumpkin",
                columns: new[] { "Agility", "Strength" },
                values: new object[] { 200, 15 });
        }
    }
}
