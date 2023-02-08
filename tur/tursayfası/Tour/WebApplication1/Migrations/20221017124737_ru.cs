using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class ru : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bolgeRUs",
                columns: table => new
                {
                    bolgeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bolgeismi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bolgeRUs", x => x.bolgeID);
                });

            migrationBuilder.CreateTable(
                name: "hakkimizdaRUs",
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
                    table.PrimaryKey("PK_hakkimizdaRUs", x => x.hakkimizdaID);
                });

            migrationBuilder.CreateTable(
                name: "hizmetTRs",
                columns: table => new
                {
                    hizmetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hizmetad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hizmetaciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ucret = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    turID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hizmetTRs", x => x.hizmetID);
                    table.ForeignKey(
                        name: "FK_hizmetTRs_TurlarTRs_turID",
                        column: x => x.turID,
                        principalTable: "TurlarTRs",
                        principalColumn: "turID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TurlarRUs",
                columns: table => new
                {
                    turID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bolgeID = table.Column<int>(type: "int", nullable: false),
                    BolgeRUbolgeID = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_TurlarRUs", x => x.turID);
                    table.ForeignKey(
                        name: "FK_TurlarRUs_bolgeRUs_BolgeRUbolgeID",
                        column: x => x.BolgeRUbolgeID,
                        principalTable: "bolgeRUs",
                        principalColumn: "bolgeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "detayGorselRUs",
                columns: table => new
                {
                    DetayGorselID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetayResim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    turID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detayGorselRUs", x => x.DetayGorselID);
                    table.ForeignKey(
                        name: "FK_detayGorselRUs_TurlarRUs_turID",
                        column: x => x.turID,
                        principalTable: "TurlarRUs",
                        principalColumn: "turID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hizmetRUs",
                columns: table => new
                {
                    hizmetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hizmetad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hizmetaciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ucret = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    turID = table.Column<int>(type: "int", nullable: false),
                    TurlarRUturID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hizmetRUs", x => x.hizmetID);
                    table.ForeignKey(
                        name: "FK_hizmetRUs_TurlarRUs_TurlarRUturID",
                        column: x => x.TurlarRUturID,
                        principalTable: "TurlarRUs",
                        principalColumn: "turID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "turdetayRUs",
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
                    table.PrimaryKey("PK_turdetayRUs", x => x.detayID);
                    table.ForeignKey(
                        name: "FK_turdetayRUs_TurlarRUs_turID",
                        column: x => x.turID,
                        principalTable: "TurlarRUs",
                        principalColumn: "turID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_detayGorselRUs_turID",
                table: "detayGorselRUs",
                column: "turID");

            migrationBuilder.CreateIndex(
                name: "IX_hizmetRUs_TurlarRUturID",
                table: "hizmetRUs",
                column: "TurlarRUturID");

            migrationBuilder.CreateIndex(
                name: "IX_hizmetTRs_turID",
                table: "hizmetTRs",
                column: "turID");

            migrationBuilder.CreateIndex(
                name: "IX_turdetayRUs_turID",
                table: "turdetayRUs",
                column: "turID");

            migrationBuilder.CreateIndex(
                name: "IX_TurlarRUs_BolgeRUbolgeID",
                table: "TurlarRUs",
                column: "BolgeRUbolgeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "detayGorselRUs");

            migrationBuilder.DropTable(
                name: "hakkimizdaRUs");

            migrationBuilder.DropTable(
                name: "hizmetRUs");

            migrationBuilder.DropTable(
                name: "hizmetTRs");

            migrationBuilder.DropTable(
                name: "turdetayRUs");

            migrationBuilder.DropTable(
                name: "TurlarRUs");

            migrationBuilder.DropTable(
                name: "bolgeRUs");
        }
    }
}
