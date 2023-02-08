using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class tr3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_detayGorselTRs_Turlars_turID",
                table: "detayGorselTRs");

            migrationBuilder.DropForeignKey(
                name: "FK_detayGorselTRs_turlarTRs_TurlarTRturID",
                table: "detayGorselTRs");

            migrationBuilder.DropForeignKey(
                name: "FK_turdetayTR_Turlars_turID",
                table: "turdetayTR");

            migrationBuilder.DropForeignKey(
                name: "FK_turdetayTR_turlarTRs_TurlarTRturID",
                table: "turdetayTR");

            migrationBuilder.DropForeignKey(
                name: "FK_Turlars_bolgeTRs_bolgeTRbolgeID",
                table: "Turlars");

            migrationBuilder.DropForeignKey(
                name: "FK_turlarTRs_bolges_bolgeID",
                table: "turlarTRs");

            migrationBuilder.DropIndex(
                name: "IX_Turlars_bolgeTRbolgeID",
                table: "Turlars");

            migrationBuilder.DropIndex(
                name: "IX_turdetayTR_TurlarTRturID",
                table: "turdetayTR");

            migrationBuilder.DropIndex(
                name: "IX_detayGorselTRs_TurlarTRturID",
                table: "detayGorselTRs");

            migrationBuilder.DropColumn(
                name: "bolgeTRbolgeID",
                table: "Turlars");

            migrationBuilder.DropColumn(
                name: "TurlarTRturID",
                table: "turdetayTR");

            migrationBuilder.DropColumn(
                name: "TurlarTRturID",
                table: "detayGorselTRs");

            migrationBuilder.AddForeignKey(
                name: "FK_detayGorselTRs_turlarTRs_turID",
                table: "detayGorselTRs",
                column: "turID",
                principalTable: "turlarTRs",
                principalColumn: "turID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_turdetayTR_turlarTRs_turID",
                table: "turdetayTR",
                column: "turID",
                principalTable: "turlarTRs",
                principalColumn: "turID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_turlarTRs_bolgeTRs_bolgeID",
                table: "turlarTRs",
                column: "bolgeID",
                principalTable: "bolgeTRs",
                principalColumn: "bolgeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_detayGorselTRs_turlarTRs_turID",
                table: "detayGorselTRs");

            migrationBuilder.DropForeignKey(
                name: "FK_turdetayTR_turlarTRs_turID",
                table: "turdetayTR");

            migrationBuilder.DropForeignKey(
                name: "FK_turlarTRs_bolgeTRs_bolgeID",
                table: "turlarTRs");

            migrationBuilder.AddColumn<int>(
                name: "bolgeTRbolgeID",
                table: "Turlars",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TurlarTRturID",
                table: "turdetayTR",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TurlarTRturID",
                table: "detayGorselTRs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Turlars_bolgeTRbolgeID",
                table: "Turlars",
                column: "bolgeTRbolgeID");

            migrationBuilder.CreateIndex(
                name: "IX_turdetayTR_TurlarTRturID",
                table: "turdetayTR",
                column: "TurlarTRturID");

            migrationBuilder.CreateIndex(
                name: "IX_detayGorselTRs_TurlarTRturID",
                table: "detayGorselTRs",
                column: "TurlarTRturID");

            migrationBuilder.AddForeignKey(
                name: "FK_detayGorselTRs_Turlars_turID",
                table: "detayGorselTRs",
                column: "turID",
                principalTable: "Turlars",
                principalColumn: "turID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_detayGorselTRs_turlarTRs_TurlarTRturID",
                table: "detayGorselTRs",
                column: "TurlarTRturID",
                principalTable: "turlarTRs",
                principalColumn: "turID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_turdetayTR_Turlars_turID",
                table: "turdetayTR",
                column: "turID",
                principalTable: "Turlars",
                principalColumn: "turID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_turdetayTR_turlarTRs_TurlarTRturID",
                table: "turdetayTR",
                column: "TurlarTRturID",
                principalTable: "turlarTRs",
                principalColumn: "turID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Turlars_bolgeTRs_bolgeTRbolgeID",
                table: "Turlars",
                column: "bolgeTRbolgeID",
                principalTable: "bolgeTRs",
                principalColumn: "bolgeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_turlarTRs_bolges_bolgeID",
                table: "turlarTRs",
                column: "bolgeID",
                principalTable: "bolges",
                principalColumn: "bolgeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
