using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddSeedDataNinjaHelmetAndChestplate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NinjaEquipments",
                keyColumns: new[] { "NinjaId", "EquipmentId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/images/equipment/helmet/golden_helmet.png");

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Agility", "Cost", "Description", "ImageUrl", "Intelligence", "Name", "Strength" },
                values: new object[] { -200, 600, "If you scared just hide in your shell.", "/images/equipment/helmet/turtle_shell.png", 20, "Shelly", 140 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "Cost", "Description", "ImageUrl", "Intelligence", "Name", "Strength" },
                values: new object[] { 0, 240, "A creepy pumpkin to scare others.", "/images/equipment/helmet/carved_pumpkin.png", 130, "Pumpkin", -10 });

            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "Id", "Agility", "Category", "Cost", "Description", "ImageUrl", "Intelligence", "Name", "Strength" },
                values: new object[,]
                {
                    { 4, -40, 1, 800, "Covers the upper body of the player.", "/images/equipment/chest/diamond_chestplate.png", 20, "Diamond Chestplate", 100 },
                    { 5, -50, 1, 1200, "Even lava can't beat this", "/images/equipment/chest/netherite_chestplate.png", 40, "Netherite Chestplate", 300 },
                    { 6, 150, 1, 350, "Helps a bit.", "/images/equipment/chest/leather_tunic.png", -70, "Leather Chestplate", 10 }
                });

            migrationBuilder.InsertData(
                table: "NinjaEquipments",
                columns: new[] { "NinjaId", "EquipmentId" },
                values: new object[] { 1, 3 });

            migrationBuilder.InsertData(
                table: "Ninjas",
                columns: new[] { "Id", "Gold", "Name", "SkinUrl" },
                values: new object[,]
                {
                    { 3, 1200, "Blockplacer", null },
                    { 4, 3200, "Stealthy", null },
                    { 5, 4000, "Epicness", null },
                    { 6, 2500, "Epic_Fat", null }
                });

            migrationBuilder.InsertData(
                table: "NinjaEquipments",
                columns: new[] { "NinjaId", "EquipmentId" },
                values: new object[,]
                {
                    { 1, 5 },
                    { 3, 1 },
                    { 3, 6 },
                    { 4, 2 },
                    { 4, 6 },
                    { 6, 2 },
                    { 6, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NinjaEquipments",
                keyColumns: new[] { "NinjaId", "EquipmentId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "NinjaEquipments",
                keyColumns: new[] { "NinjaId", "EquipmentId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "NinjaEquipments",
                keyColumns: new[] { "NinjaId", "EquipmentId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "NinjaEquipments",
                keyColumns: new[] { "NinjaId", "EquipmentId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "NinjaEquipments",
                keyColumns: new[] { "NinjaId", "EquipmentId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "NinjaEquipments",
                keyColumns: new[] { "NinjaId", "EquipmentId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "NinjaEquipments",
                keyColumns: new[] { "NinjaId", "EquipmentId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "NinjaEquipments",
                keyColumns: new[] { "NinjaId", "EquipmentId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/images/equipment/head/golden_helmet.png");

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Agility", "Cost", "Description", "ImageUrl", "Intelligence", "Name", "Strength" },
                values: new object[] { -50, 20, "A creepy pumpkin to scare others.", "/images/equipment/head/carved_pumpkin.png", -40, "Pumpkin", 25 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "Cost", "Description", "ImageUrl", "Intelligence", "Name", "Strength" },
                values: new object[] { 1, 800, "Covers the upper body of the player.", "/images/equipment/chest/diamond_chestplate.png", 20, "Diamond Chestplate", 100 });

            migrationBuilder.InsertData(
                table: "NinjaEquipments",
                columns: new[] { "NinjaId", "EquipmentId" },
                values: new object[] { 1, 1 });
        }
    }
}
