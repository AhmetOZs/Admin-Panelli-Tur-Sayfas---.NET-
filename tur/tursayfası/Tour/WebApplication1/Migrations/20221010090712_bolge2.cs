using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class bolge2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bolge_Turlars_turID",
                table: "bolge");

            migrationBuilder.DropPrimaryKey(
                name: "PK_bolge",
                table: "bolge");

            migrationBuilder.RenameTable(
                name: "bolge",
                newName: "bolges");

            migrationBuilder.RenameIndex(
                name: "IX_bolge_turID",
                table: "bolges",
                newName: "IX_bolges_turID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_bolges",
                table: "bolges",
                column: "bolgeID");

            migrationBuilder.AddForeignKey(
                name: "FK_bolges_Turlars_turID",
                table: "bolges",
                column: "turID",
                principalTable: "Turlars",
                principalColumn: "turID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bolges_Turlars_turID",
                table: "bolges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_bolges",
                table: "bolges");

            migrationBuilder.RenameTable(
                name: "bolges",
                newName: "bolge");

            migrationBuilder.RenameIndex(
                name: "IX_bolges_turID",
                table: "bolge",
                newName: "IX_bolge_turID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_bolge",
                table: "bolge",
                column: "bolgeID");

            migrationBuilder.AddForeignKey(
                name: "FK_bolge_Turlars_turID",
                table: "bolge",
                column: "turID",
                principalTable: "Turlars",
                principalColumn: "turID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
