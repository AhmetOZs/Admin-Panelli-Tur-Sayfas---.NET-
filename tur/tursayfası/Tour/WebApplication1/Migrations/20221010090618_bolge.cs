using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class bolge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turlars_Turlars_TurlarturID",
                table: "Turlars");

            migrationBuilder.DropIndex(
                name: "IX_Turlars_TurlarturID",
                table: "Turlars");

            migrationBuilder.DropColumn(
                name: "TurlarturID",
                table: "Turlars");

            migrationBuilder.CreateTable(
                name: "bolge",
                columns: table => new
                {
                    bolgeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bolgeismi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    turID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bolge", x => x.bolgeID);
                    table.ForeignKey(
                        name: "FK_bolge_Turlars_turID",
                        column: x => x.turID,
                        principalTable: "Turlars",
                        principalColumn: "turID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_bolge_turID",
                table: "bolge",
                column: "turID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bolge");

            migrationBuilder.AddColumn<int>(
                name: "TurlarturID",
                table: "Turlars",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Turlars_TurlarturID",
                table: "Turlars",
                column: "TurlarturID");

            migrationBuilder.AddForeignKey(
                name: "FK_Turlars_Turlars_TurlarturID",
                table: "Turlars",
                column: "TurlarturID",
                principalTable: "Turlars",
                principalColumn: "turID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
