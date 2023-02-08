using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class tutarihdiger : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "turTarihRUs",
                columns: table => new
                {
                    tarihID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tarih = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    turID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_turTarihRUs", x => x.tarihID);
                    table.ForeignKey(
                        name: "FK_turTarihRUs_TurlarRUs_turID",
                        column: x => x.turID,
                        principalTable: "TurlarRUs",
                        principalColumn: "turID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "turTarihTRs",
                columns: table => new
                {
                    tarihID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tarih = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    turID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_turTarihTRs", x => x.tarihID);
                    table.ForeignKey(
                        name: "FK_turTarihTRs_TurlarTRs_turID",
                        column: x => x.turID,
                        principalTable: "TurlarTRs",
                        principalColumn: "turID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_turTarihRUs_turID",
                table: "turTarihRUs",
                column: "turID");

            migrationBuilder.CreateIndex(
                name: "IX_turTarihTRs_turID",
                table: "turTarihTRs",
                column: "turID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "turTarihRUs");

            migrationBuilder.DropTable(
                name: "turTarihTRs");
        }
    }
}
