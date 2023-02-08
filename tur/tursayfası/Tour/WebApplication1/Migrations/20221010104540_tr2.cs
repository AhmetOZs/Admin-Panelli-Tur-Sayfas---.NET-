using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class tr2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "bolgeTRbolgeID",
                table: "Turlars",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "bolgeTRs",
                columns: table => new
                {
                    bolgeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bolgeismi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bolgeTRs", x => x.bolgeID);
                });

            migrationBuilder.CreateTable(
                name: "hakkimizdaTRs",
                columns: table => new
                {
                    hakkimizdaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hakkimizdabaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hakkimizdaaciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hakkimizdavideo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hakkimizdaTRs", x => x.hakkimizdaID);
                });

            migrationBuilder.CreateTable(
                name: "turlarTRs",
                columns: table => new
                {
                    turID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bolgeID = table.Column<int>(type: "int", nullable: false),
                    Bolgesicaklik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sehir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    girisresim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    turismi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    turtarihi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ucret = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kontejyan = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_turlarTRs", x => x.turID);
                    table.ForeignKey(
                        name: "FK_turlarTRs_bolges_bolgeID",
                        column: x => x.bolgeID,
                        principalTable: "bolges",
                        principalColumn: "bolgeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "detayGorselTRs",
                columns: table => new
                {
                    DetayGorselID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetayResim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    turID = table.Column<int>(type: "int", nullable: false),
                    TurlarTRturID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detayGorselTRs", x => x.DetayGorselID);
                    table.ForeignKey(
                        name: "FK_detayGorselTRs_Turlars_turID",
                        column: x => x.turID,
                        principalTable: "Turlars",
                        principalColumn: "turID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_detayGorselTRs_turlarTRs_TurlarTRturID",
                        column: x => x.TurlarTRturID,
                        principalTable: "turlarTRs",
                        principalColumn: "turID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "turdetayTR",
                columns: table => new
                {
                    detayID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    detayresim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    detaybaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    detayaciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    turID = table.Column<int>(type: "int", nullable: false),
                    TurlarTRturID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_turdetayTR", x => x.detayID);
                    table.ForeignKey(
                        name: "FK_turdetayTR_Turlars_turID",
                        column: x => x.turID,
                        principalTable: "Turlars",
                        principalColumn: "turID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_turdetayTR_turlarTRs_TurlarTRturID",
                        column: x => x.TurlarTRturID,
                        principalTable: "turlarTRs",
                        principalColumn: "turID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Turlars_bolgeTRbolgeID",
                table: "Turlars",
                column: "bolgeTRbolgeID");

            migrationBuilder.CreateIndex(
                name: "IX_detayGorselTRs_turID",
                table: "detayGorselTRs",
                column: "turID");

            migrationBuilder.CreateIndex(
                name: "IX_detayGorselTRs_TurlarTRturID",
                table: "detayGorselTRs",
                column: "TurlarTRturID");

            migrationBuilder.CreateIndex(
                name: "IX_turdetayTR_turID",
                table: "turdetayTR",
                column: "turID");

            migrationBuilder.CreateIndex(
                name: "IX_turdetayTR_TurlarTRturID",
                table: "turdetayTR",
                column: "TurlarTRturID");

            migrationBuilder.CreateIndex(
                name: "IX_turlarTRs_bolgeID",
                table: "turlarTRs",
                column: "bolgeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Turlars_bolgeTRs_bolgeTRbolgeID",
                table: "Turlars",
                column: "bolgeTRbolgeID",
                principalTable: "bolgeTRs",
                principalColumn: "bolgeID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turlars_bolgeTRs_bolgeTRbolgeID",
                table: "Turlars");

            migrationBuilder.DropTable(
                name: "bolgeTRs");

            migrationBuilder.DropTable(
                name: "detayGorselTRs");

            migrationBuilder.DropTable(
                name: "hakkimizdaTRs");

            migrationBuilder.DropTable(
                name: "turdetayTR");

            migrationBuilder.DropTable(
                name: "turlarTRs");

            migrationBuilder.DropIndex(
                name: "IX_Turlars_bolgeTRbolgeID",
                table: "Turlars");

            migrationBuilder.DropColumn(
                name: "bolgeTRbolgeID",
                table: "Turlars");
        }
    }
}
