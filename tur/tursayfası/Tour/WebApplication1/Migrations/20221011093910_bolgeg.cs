using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class bolgeg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_turlarTRs_bolgeTRs_bolgeID",
                table: "turlarTRs");

            migrationBuilder.DropIndex(
                name: "IX_turlarTRs_bolgeID",
                table: "turlarTRs");

            migrationBuilder.AddColumn<int>(
                name: "bolgeTRsbolgeID",
                table: "turlarTRs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_turlarTRs_bolgeTRsbolgeID",
                table: "turlarTRs",
                column: "bolgeTRsbolgeID");

            migrationBuilder.AddForeignKey(
                name: "FK_turlarTRs_bolgeTRs_bolgeTRsbolgeID",
                table: "turlarTRs",
                column: "bolgeTRsbolgeID",
                principalTable: "bolgeTRs",
                principalColumn: "bolgeID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_turlarTRs_bolgeTRs_bolgeTRsbolgeID",
                table: "turlarTRs");

            migrationBuilder.DropIndex(
                name: "IX_turlarTRs_bolgeTRsbolgeID",
                table: "turlarTRs");

            migrationBuilder.DropColumn(
                name: "bolgeTRsbolgeID",
                table: "turlarTRs");

            migrationBuilder.CreateIndex(
                name: "IX_turlarTRs_bolgeID",
                table: "turlarTRs",
                column: "bolgeID");

            migrationBuilder.AddForeignKey(
                name: "FK_turlarTRs_bolgeTRs_bolgeID",
                table: "turlarTRs",
                column: "bolgeID",
                principalTable: "bolgeTRs",
                principalColumn: "bolgeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
