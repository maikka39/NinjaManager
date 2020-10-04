using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class MoreDetailedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "Name",
                keyValue: "Diamond Chestplate",
                columns: new[] { "Agility", "Intelligence", "Strength" },
                values: new object[] { -50, 20, 100 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "Name",
                keyValue: "Fancy Hat",
                columns: new[] { "Agility", "Intelligence", "Strength" },
                values: new object[] { 200, 30, 5 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "Name",
                keyValue: "Pumpkin",
                columns: new[] { "Agility", "Intelligence", "Strength" },
                values: new object[] { 200, -40, 15 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "Name",
                keyValue: "Diamond Chestplate",
                columns: new[] { "Agility", "Intelligence", "Strength" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "Name",
                keyValue: "Fancy Hat",
                columns: new[] { "Agility", "Intelligence", "Strength" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "Name",
                keyValue: "Pumpkin",
                columns: new[] { "Agility", "Intelligence", "Strength" },
                values: new object[] { 0, 0, 0 });
        }
    }
}
