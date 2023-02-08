using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class bolge3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bolges_Turlars_turID",
                table: "bolges");

            migrationBuilder.DropIndex(
                name: "IX_bolges_turID",
                table: "bolges");

            migrationBuilder.DropColumn(
                name: "bolge",
                table: "Turlars");

            migrationBuilder.DropColumn(
                name: "turID",
                table: "bolges");

            migrationBuilder.AddColumn<int>(
                name: "bolgeID",
                table: "Turlars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Turlars_bolgeID",
                table: "Turlars",
                column: "bolgeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Turlars_bolges_bolgeID",
                table: "Turlars",
                column: "bolgeID",
                principalTable: "bolges",
                principalColumn: "bolgeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turlars_bolges_bolgeID",
                table: "Turlars");

            migrationBuilder.DropIndex(
                name: "IX_Turlars_bolgeID",
                table: "Turlars");

            migrationBuilder.DropColumn(
                name: "bolgeID",
                table: "Turlars");

            migrationBuilder.AddColumn<string>(
                name: "bolge",
                table: "Turlars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "turID",
                table: "bolges",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_bolges_turID",
                table: "bolges",
                column: "turID");

            migrationBuilder.AddForeignKey(
                name: "FK_bolges_Turlars_turID",
                table: "bolges",
                column: "turID",
                principalTable: "Turlars",
                principalColumn: "turID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
