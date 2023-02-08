using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class yeniturlartr3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TurlarTRs_bolges_bolgeID",
                table: "TurlarTRs");

            migrationBuilder.DropForeignKey(
                name: "FK_TurlarTRs_bolgeTRs_bolgeTRbolgeID",
                table: "TurlarTRs");

            migrationBuilder.DropIndex(
                name: "IX_TurlarTRs_bolgeID",
                table: "TurlarTRs");

            migrationBuilder.RenameColumn(
                name: "bolgeTRbolgeID",
                table: "TurlarTRs",
                newName: "BolgeTRbolgeID");

            migrationBuilder.RenameIndex(
                name: "IX_TurlarTRs_bolgeTRbolgeID",
                table: "TurlarTRs",
                newName: "IX_TurlarTRs_BolgeTRbolgeID");

            migrationBuilder.AddForeignKey(
                name: "FK_TurlarTRs_bolgeTRs_BolgeTRbolgeID",
                table: "TurlarTRs",
                column: "BolgeTRbolgeID",
                principalTable: "bolgeTRs",
                principalColumn: "bolgeID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TurlarTRs_bolgeTRs_BolgeTRbolgeID",
                table: "TurlarTRs");

            migrationBuilder.RenameColumn(
                name: "BolgeTRbolgeID",
                table: "TurlarTRs",
                newName: "bolgeTRbolgeID");

            migrationBuilder.RenameIndex(
                name: "IX_TurlarTRs_BolgeTRbolgeID",
                table: "TurlarTRs",
                newName: "IX_TurlarTRs_bolgeTRbolgeID");

            migrationBuilder.CreateIndex(
                name: "IX_TurlarTRs_bolgeID",
                table: "TurlarTRs",
                column: "bolgeID");

            migrationBuilder.AddForeignKey(
                name: "FK_TurlarTRs_bolges_bolgeID",
                table: "TurlarTRs",
                column: "bolgeID",
                principalTable: "bolges",
                principalColumn: "bolgeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TurlarTRs_bolgeTRs_bolgeTRbolgeID",
                table: "TurlarTRs",
                column: "bolgeTRbolgeID",
                principalTable: "bolgeTRs",
                principalColumn: "bolgeID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
