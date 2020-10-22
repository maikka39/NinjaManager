using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddIdToEquipment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Equipment",
                table: "Equipment");

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Name",
                keyValue: "Diamond Chestplate");

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Name",
                keyValue: "Fancy Hat");

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Name",
                keyValue: "Pumpkin");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Equipment",
                maxLength: 40,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Equipment",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Equipment",
                table: "Equipment",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Equipment",
                columns: new[] { "Id", "Agility", "Category", "Cost", "Description", "ImageUrl", "Intelligence", "Name", "Strength" },
                values: new object[] { 1, 200, 0, 300, "A cheap basic hat which makes you go a little faster.", "/images/equipment/head/golden_helmet.png", 30, "Fancy Hat", 5 });

            migrationBuilder.InsertData(
                table: "Equipment",
                columns: new[] { "Id", "Agility", "Category", "Cost", "Description", "ImageUrl", "Intelligence", "Name", "Strength" },
                values: new object[] { 2, -50, 0, 20, "A creepy pumpkin to scare others.", "/images/equipment/head/carved_pumpkin.png", -40, "Pumpkin", 25 });

            migrationBuilder.InsertData(
                table: "Equipment",
                columns: new[] { "Id", "Agility", "Category", "Cost", "Description", "ImageUrl", "Intelligence", "Name", "Strength" },
                values: new object[] { 3, -50, 1, 800, "Covers the upper body of the player.", "/images/equipment/chest/diamond_chestplate.png", 20, "Diamond Chestplate", 100 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Equipment",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Equipment");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Equipment",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 40,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Equipment",
                table: "Equipment",
                column: "Name");
        }
    }
}
