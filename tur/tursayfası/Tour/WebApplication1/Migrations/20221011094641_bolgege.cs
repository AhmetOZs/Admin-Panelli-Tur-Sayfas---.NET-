using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class bolgege : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_turlarTRs_bolgeTRs_bolgeTRsbolgeID",
                table: "turlarTRs");

            migrationBuilder.RenameColumn(
                name: "bolgeTRsbolgeID",
                table: "turlarTRs",
                newName: "BolgeTRbolgeID");

            migrationBuilder.RenameIndex(
                name: "IX_turlarTRs_bolgeTRsbolgeID",
                table: "turlarTRs",
                newName: "IX_turlarTRs_BolgeTRbolgeID");

            migrationBuilder.AddForeignKey(
                name: "FK_turlarTRs_bolgeTRs_BolgeTRbolgeID",
                table: "turlarTRs",
                column: "BolgeTRbolgeID",
                principalTable: "bolgeTRs",
                principalColumn: "bolgeID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_turlarTRs_bolgeTRs_BolgeTRbolgeID",
                table: "turlarTRs");

            migrationBuilder.RenameColumn(
                name: "BolgeTRbolgeID",
                table: "turlarTRs",
                newName: "bolgeTRsbolgeID");

            migrationBuilder.RenameIndex(
                name: "IX_turlarTRs_BolgeTRbolgeID",
                table: "turlarTRs",
                newName: "IX_turlarTRs_bolgeTRsbolgeID");

            migrationBuilder.AddForeignKey(
                name: "FK_turlarTRs_bolgeTRs_bolgeTRsbolgeID",
                table: "turlarTRs",
                column: "bolgeTRsbolgeID",
                principalTable: "bolgeTRs",
                principalColumn: "bolgeID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
