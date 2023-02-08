using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class deneme5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetayGorsel_Turlars_turID",
                table: "DetayGorsel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetayGorsel",
                table: "DetayGorsel");

            migrationBuilder.RenameTable(
                name: "DetayGorsel",
                newName: "detayGorsels");

            migrationBuilder.RenameIndex(
                name: "IX_DetayGorsel_turID",
                table: "detayGorsels",
                newName: "IX_detayGorsels_turID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_detayGorsels",
                table: "detayGorsels",
                column: "DetayGorselID");

            migrationBuilder.AddForeignKey(
                name: "FK_detayGorsels_Turlars_turID",
                table: "detayGorsels",
                column: "turID",
                principalTable: "Turlars",
                principalColumn: "turID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_detayGorsels_Turlars_turID",
                table: "detayGorsels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_detayGorsels",
                table: "detayGorsels");

            migrationBuilder.RenameTable(
                name: "detayGorsels",
                newName: "DetayGorsel");

            migrationBuilder.RenameIndex(
                name: "IX_detayGorsels_turID",
                table: "DetayGorsel",
                newName: "IX_DetayGorsel_turID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetayGorsel",
                table: "DetayGorsel",
                column: "DetayGorselID");

            migrationBuilder.AddForeignKey(
                name: "FK_DetayGorsel_Turlars_turID",
                table: "DetayGorsel",
                column: "turID",
                principalTable: "Turlars",
                principalColumn: "turID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
