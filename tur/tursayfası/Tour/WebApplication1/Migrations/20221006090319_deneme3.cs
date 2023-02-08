using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class deneme3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_turlars_turlars_TurlarturID",
                table: "turlars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_turlars",
                table: "turlars");

            migrationBuilder.RenameTable(
                name: "turlars",
                newName: "Turlars");

            migrationBuilder.RenameIndex(
                name: "IX_turlars_TurlarturID",
                table: "Turlars",
                newName: "IX_Turlars_TurlarturID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Turlars",
                table: "Turlars",
                column: "turID");

            migrationBuilder.CreateTable(
                name: "turdetays",
                columns: table => new
                {
                    detayID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    detayresim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    detaybaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    detayaciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    turID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_turdetays", x => x.detayID);
                    table.ForeignKey(
                        name: "FK_turdetays_Turlars_turID",
                        column: x => x.turID,
                        principalTable: "Turlars",
                        principalColumn: "turID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_turdetays_turID",
                table: "turdetays",
                column: "turID");

            migrationBuilder.AddForeignKey(
                name: "FK_Turlars_Turlars_TurlarturID",
                table: "Turlars",
                column: "TurlarturID",
                principalTable: "Turlars",
                principalColumn: "turID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turlars_Turlars_TurlarturID",
                table: "Turlars");

            migrationBuilder.DropTable(
                name: "turdetays");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Turlars",
                table: "Turlars");

            migrationBuilder.RenameTable(
                name: "Turlars",
                newName: "turlars");

            migrationBuilder.RenameIndex(
                name: "IX_Turlars_TurlarturID",
                table: "turlars",
                newName: "IX_turlars_TurlarturID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_turlars",
                table: "turlars",
                column: "turID");

            migrationBuilder.AddForeignKey(
                name: "FK_turlars_turlars_TurlarturID",
                table: "turlars",
                column: "TurlarturID",
                principalTable: "turlars",
                principalColumn: "turID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
