using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class deneme2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "detayaciklama",
                table: "turlars");

            migrationBuilder.DropColumn(
                name: "detaybaslik",
                table: "turlars");

            migrationBuilder.DropColumn(
                name: "detayresim",
                table: "turlars");

            migrationBuilder.AddColumn<int>(
                name: "TurlarturID",
                table: "turlars",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_turlars_TurlarturID",
                table: "turlars",
                column: "TurlarturID");

            migrationBuilder.AddForeignKey(
                name: "FK_turlars_turlars_TurlarturID",
                table: "turlars",
                column: "TurlarturID",
                principalTable: "turlars",
                principalColumn: "turID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_turlars_turlars_TurlarturID",
                table: "turlars");

            migrationBuilder.DropIndex(
                name: "IX_turlars_TurlarturID",
                table: "turlars");

            migrationBuilder.DropColumn(
                name: "TurlarturID",
                table: "turlars");

            migrationBuilder.AddColumn<string>(
                name: "detayaciklama",
                table: "turlars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "detaybaslik",
                table: "turlars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "detayresim",
                table: "turlars",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
