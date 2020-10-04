using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "Equipment",
                table => new
                {
                    Name = table.Column<string>(maxLength: 40, nullable: false),
                    Cost = table.Column<int>(nullable: false),
                    Category = table.Column<int>(nullable: false),
                    Strength = table.Column<int>(nullable: false),
                    Intelligence = table.Column<int>(nullable: false),
                    Agility = table.Column<int>(nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_Equipment", x => x.Name); });

            migrationBuilder.CreateTable(
                "Ninjas",
                table => new
                {
                    Name = table.Column<string>(maxLength: 40, nullable: false),
                    Gold = table.Column<int>(nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_Ninjas", x => x.Name); });

            migrationBuilder.InsertData(
                "Equipment",
                new[] {"Name", "Agility", "Category", "Cost", "Intelligence", "Strength"},
                new object[,]
                {
                    {"Fancy Hat", 0, 0, 300, 0, 0},
                    {"Pumpkin", 0, 0, 20, 0, 0},
                    {"Diamond Chestplate", 0, 1, 800, 0, 0}
                });

            migrationBuilder.InsertData(
                "Ninjas",
                new[] {"Name", "Gold"},
                new object[] {"Awesome_ninja67", 2000});
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "Equipment");

            migrationBuilder.DropTable(
                "Ninjas");
        }
    }
}