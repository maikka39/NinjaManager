using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class TestSkin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: 2,
                column: "SkinUrl",
                value: "/images/skins/alex.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ninjas",
                keyColumn: "Id",
                keyValue: 2,
                column: "SkinUrl",
                value: null);
        }
    }
}
