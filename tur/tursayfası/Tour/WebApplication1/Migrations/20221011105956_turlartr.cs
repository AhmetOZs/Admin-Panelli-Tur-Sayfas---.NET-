using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class turlartr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_detayGorselTRs_turlarTRs_turID",
                table: "detayGorselTRs");

            migrationBuilder.DropForeignKey(
                name: "FK_turdetayTRs_turlarTRs_turID",
                table: "turdetayTRs");

            migrationBuilder.DropForeignKey(
                name: "FK_turlarTRs_bolgeTRs_BolgeTRbolgeID",
                table: "turlarTRs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_turlarTRs",
                table: "turlarTRs");

            migrationBuilder.RenameTable(
                name: "turlarTRs",
                newName: "TurlarTRs");

            migrationBuilder.RenameIndex(
                name: "IX_turlarTRs_BolgeTRbolgeID",
                table: "TurlarTRs",
                newName: "IX_TurlarTRs_BolgeTRbolgeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TurlarTRs",
                table: "TurlarTRs",
                column: "turID");

            migrationBuilder.AddForeignKey(
                name: "FK_detayGorselTRs_TurlarTRs_turID",
                table: "detayGorselTRs",
                column: "turID",
                principalTable: "TurlarTRs",
                principalColumn: "turID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_turdetayTRs_TurlarTRs_turID",
                table: "turdetayTRs",
                column: "turID",
                principalTable: "TurlarTRs",
                principalColumn: "turID",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_detayGorselTRs_TurlarTRs_turID",
                table: "detayGorselTRs");

            migrationBuilder.DropForeignKey(
                name: "FK_turdetayTRs_TurlarTRs_turID",
                table: "turdetayTRs");

            migrationBuilder.DropForeignKey(
                name: "FK_TurlarTRs_bolgeTRs_BolgeTRbolgeID",
                table: "TurlarTRs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TurlarTRs",
                table: "TurlarTRs");

            migrationBuilder.RenameTable(
                name: "TurlarTRs",
                newName: "turlarTRs");

            migrationBuilder.RenameIndex(
                name: "IX_TurlarTRs_BolgeTRbolgeID",
                table: "turlarTRs",
                newName: "IX_turlarTRs_BolgeTRbolgeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_turlarTRs",
                table: "turlarTRs",
                column: "turID");

            migrationBuilder.AddForeignKey(
                name: "FK_detayGorselTRs_turlarTRs_turID",
                table: "detayGorselTRs",
                column: "turID",
                principalTable: "turlarTRs",
                principalColumn: "turID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_turdetayTRs_turlarTRs_turID",
                table: "turdetayTRs",
                column: "turID",
                principalTable: "turlarTRs",
                principalColumn: "turID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_turlarTRs_bolgeTRs_BolgeTRbolgeID",
                table: "turlarTRs",
                column: "BolgeTRbolgeID",
                principalTable: "bolgeTRs",
                principalColumn: "bolgeID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
