using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class InsertLeggins : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "Regeneration Potion");

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 18,
                column: "Name",
                value: "Swiftness Potion");

            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "Id", "Agility", "Category", "Cost", "Description", "ImageUrl", "Intelligence", "Name", "Strength" },
                values: new object[,]
                {
                    { 7, 40, 2, 160, "Nice thick leather to keep your butt warm.", "/images/equipment/leggings/chainmail_leggings.png", 30, "Chainmail Leggings", 10 },
                    { 8, -80, 2, 320, "Just some nice pants.", "/images/equipment/leggings/iron_leggings.png", 100, "Iron Leggings", 60 },
                    { 9, -10, 2, 470, "Helps just a bit.", "/images/equipment/leggings/diamond_leggings.png", -40, "Diamond Leggings", 360 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "Regeneration potion");

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 18,
                column: "Name",
                value: "Swiftness potion");
        }
    }
}
