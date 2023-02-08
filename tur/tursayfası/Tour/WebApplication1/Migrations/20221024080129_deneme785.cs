using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class deneme785 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {



            migrationBuilder.CreateIndex(
                name: "IX_TurlarTRs_bolgeID",
                table: "TurlarTRs",
                column: "bolgeID");

            migrationBuilder.AddForeignKey(
                name: "FK_TurlarTRs_bolgeTRs_bolgeID",
                table: "TurlarTRs",
                column: "bolgeID",
                principalTable: "bolgeTRs",
                principalColumn: "bolgeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.AddColumn<int>(
                name: "BolgeTRbolgeID",
                table: "TurlarTRs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TurlarTRs_BolgeTRbolgeID",
                table: "TurlarTRs",
                column: "BolgeTRbolgeID");

            migrationBuilder.AddForeignKey(
                name: "FK_TurlarTRs_bolgeTRs_BolgeTRbolgeID",
                table: "TurlarTRs",
                column: "BolgeTRbolgeID",
                principalTable: "bolgeTRs",
                principalColumn: "bolgeID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
