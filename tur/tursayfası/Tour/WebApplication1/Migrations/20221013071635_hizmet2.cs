using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class hizmet2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_hizmet_Turlars_turID",
                table: "hizmet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_hizmet",
                table: "hizmet");

            migrationBuilder.RenameTable(
                name: "hizmet",
                newName: "hizmets");

            migrationBuilder.RenameIndex(
                name: "IX_hizmet_turID",
                table: "hizmets",
                newName: "IX_hizmets_turID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_hizmets",
                table: "hizmets",
                column: "hizmetID");

            migrationBuilder.AddForeignKey(
                name: "FK_hizmets_Turlars_turID",
                table: "hizmets",
                column: "turID",
                principalTable: "Turlars",
                principalColumn: "turID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_hizmets_Turlars_turID",
                table: "hizmets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_hizmets",
                table: "hizmets");

            migrationBuilder.RenameTable(
                name: "hizmets",
                newName: "hizmet");

            migrationBuilder.RenameIndex(
                name: "IX_hizmets_turID",
                table: "hizmet",
                newName: "IX_hizmet_turID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_hizmet",
                table: "hizmet",
                column: "hizmetID");

            migrationBuilder.AddForeignKey(
                name: "FK_hizmet_Turlars_turID",
                table: "hizmet",
                column: "turID",
                principalTable: "Turlars",
                principalColumn: "turID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
