using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class tr4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_turdetayTR_turlarTRs_turID",
                table: "turdetayTR");

            migrationBuilder.DropPrimaryKey(
                name: "PK_turdetayTR",
                table: "turdetayTR");

            migrationBuilder.RenameTable(
                name: "turdetayTR",
                newName: "turdetayTRs");

            migrationBuilder.RenameIndex(
                name: "IX_turdetayTR_turID",
                table: "turdetayTRs",
                newName: "IX_turdetayTRs_turID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_turdetayTRs",
                table: "turdetayTRs",
                column: "detayID");

            migrationBuilder.AddForeignKey(
                name: "FK_turdetayTRs_turlarTRs_turID",
                table: "turdetayTRs",
                column: "turID",
                principalTable: "turlarTRs",
                principalColumn: "turID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_turdetayTRs_turlarTRs_turID",
                table: "turdetayTRs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_turdetayTRs",
                table: "turdetayTRs");

            migrationBuilder.RenameTable(
                name: "turdetayTRs",
                newName: "turdetayTR");

            migrationBuilder.RenameIndex(
                name: "IX_turdetayTRs_turID",
                table: "turdetayTR",
                newName: "IX_turdetayTR_turID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_turdetayTR",
                table: "turdetayTR",
                column: "detayID");

            migrationBuilder.AddForeignKey(
                name: "FK_turdetayTR_turlarTRs_turID",
                table: "turdetayTR",
                column: "turID",
                principalTable: "turlarTRs",
                principalColumn: "turID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
