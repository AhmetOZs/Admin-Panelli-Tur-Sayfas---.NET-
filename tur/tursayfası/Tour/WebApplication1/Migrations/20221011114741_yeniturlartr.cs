using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class yeniturlartr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "turID",
                table: "turdetayTRs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "turID",
                table: "detayGorselTRs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TurlarTRs",
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
                    kontejyan = table.Column<int>(type: "int", nullable: false),
                    bolgeTRbolgeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TurlarTRs", x => x.turID);
                    table.ForeignKey(
                        name: "FK_TurlarTRs_bolges_bolgeID",
                        column: x => x.bolgeID,
                        principalTable: "bolges",
                        principalColumn: "bolgeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TurlarTRs_bolgeTRs_bolgeTRbolgeID",
                        column: x => x.bolgeTRbolgeID,
                        principalTable: "bolgeTRs",
                        principalColumn: "bolgeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_turdetayTRs_turID",
                table: "turdetayTRs",
                column: "turID");

            migrationBuilder.CreateIndex(
                name: "IX_detayGorselTRs_turID",
                table: "detayGorselTRs",
                column: "turID");

            migrationBuilder.CreateIndex(
                name: "IX_TurlarTRs_bolgeID",
                table: "TurlarTRs",
                column: "bolgeID");

            migrationBuilder.CreateIndex(
                name: "IX_TurlarTRs_bolgeTRbolgeID",
                table: "TurlarTRs",
                column: "bolgeTRbolgeID");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_detayGorselTRs_TurlarTRs_turID",
                table: "detayGorselTRs");

            migrationBuilder.DropForeignKey(
                name: "FK_turdetayTRs_TurlarTRs_turID",
                table: "turdetayTRs");

            migrationBuilder.DropTable(
                name: "TurlarTRs");

            migrationBuilder.DropIndex(
                name: "IX_turdetayTRs_turID",
                table: "turdetayTRs");

            migrationBuilder.DropIndex(
                name: "IX_detayGorselTRs_turID",
                table: "detayGorselTRs");

            migrationBuilder.DropColumn(
                name: "turID",
                table: "turdetayTRs");

            migrationBuilder.DropColumn(
                name: "turID",
                table: "detayGorselTRs");
        }
    }
}
