using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class RenameColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NinjaEquipment_Equipment_EquipmentId",
                table: "NinjaEquipment");

            migrationBuilder.DropForeignKey(
                name: "FK_NinjaEquipment_Ninjas_NinjaId",
                table: "NinjaEquipment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NinjaEquipment",
                table: "NinjaEquipment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Equipment",
                table: "Equipment");

            migrationBuilder.RenameTable(
                name: "NinjaEquipment",
                newName: "NinjaEquipments");

            migrationBuilder.RenameTable(
                name: "Equipment",
                newName: "Equipments");

            migrationBuilder.RenameIndex(
                name: "IX_NinjaEquipment_EquipmentId",
                table: "NinjaEquipments",
                newName: "IX_NinjaEquipments_EquipmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NinjaEquipments",
                table: "NinjaEquipments",
                columns: new[] { "NinjaId", "EquipmentId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Equipments",
                table: "Equipments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NinjaEquipments_Equipments_EquipmentId",
                table: "NinjaEquipments",
                column: "EquipmentId",
                principalTable: "Equipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NinjaEquipments_Ninjas_NinjaId",
                table: "NinjaEquipments",
                column: "NinjaId",
                principalTable: "Ninjas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NinjaEquipments_Equipments_EquipmentId",
                table: "NinjaEquipments");

            migrationBuilder.DropForeignKey(
                name: "FK_NinjaEquipments_Ninjas_NinjaId",
                table: "NinjaEquipments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NinjaEquipments",
                table: "NinjaEquipments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Equipments",
                table: "Equipments");

            migrationBuilder.RenameTable(
                name: "NinjaEquipments",
                newName: "NinjaEquipment");

            migrationBuilder.RenameTable(
                name: "Equipments",
                newName: "Equipment");

            migrationBuilder.RenameIndex(
                name: "IX_NinjaEquipments_EquipmentId",
                table: "NinjaEquipment",
                newName: "IX_NinjaEquipment_EquipmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NinjaEquipment",
                table: "NinjaEquipment",
                columns: new[] { "NinjaId", "EquipmentId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Equipment",
                table: "Equipment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NinjaEquipment_Equipment_EquipmentId",
                table: "NinjaEquipment",
                column: "EquipmentId",
                principalTable: "Equipment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NinjaEquipment_Ninjas_NinjaId",
                table: "NinjaEquipment",
                column: "NinjaId",
                principalTable: "Ninjas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
