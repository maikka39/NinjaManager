using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddSeedDataAllRemainingItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "Id", "Agility", "Category", "Cost", "Description", "ImageUrl", "Intelligence", "Name", "Strength" },
                values: new object[,]
                {
                    { 10, 110, 3, 90, "Nice thick leather to keep your feet warm.", "/images/equipment/boots/leather_boots.png", -30, "Leather Boots", 0 },
                    { 11, -30, 3, 220, "Just some nice shiny shoes.", "/images/equipment/boots/iron_boots.png", 10, "Iron Boots", 160 },
                    { 12, 20, 3, 440, "Heavy metal rock shoes.", "/images/equipment/boots/netherite_boots.png", -30, "Netherite Boots", 160 },
                    { 13, 10, 4, 40, "Cheap gold but it's good looking.", "/images/equipment/sword/golden_sword.png", 10, "Golden Sword", 20 },
                    { 14, -30, 4, 220, "Will do the trick.", "/images/equipment/sword/iron_sword.png", 10, "Iron Sword", 160 },
                    { 15, 80, 4, 640, "Heavy metal blade of doom.", "/images/equipment/sword/netherite_sword.png", 60, "Netherite Sword", 430 },
                    { 16, 0, 5, 300, "To see everything.", "/images/equipment/potion/Potion_of_Night_Vision.gif", 300, "Night Vision Potion", 0 },
                    { 17, 0, 5, 300, "If you need some more time.", "/images/equipment/potion/Potion_of_Regeneration.gif", 0, "Regeneration potion", 300 },
                    { 18, 300, 5, 300, "If you're in a hurry.", "/images/equipment/potion/Potion_of_Swiftness.gif", 0, "Swiftness potion", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 18);
        }
    }
}
