using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class yorum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TurlarRUs_bolgeRUs_BolgeRUbolgeID",
                table: "TurlarRUs");

            migrationBuilder.DropIndex(
                name: "IX_TurlarRUs_BolgeRUbolgeID",
                table: "TurlarRUs");

            migrationBuilder.DropColumn(
                name: "BolgeRUbolgeID",
                table: "TurlarRUs");

            migrationBuilder.CreateTable(
                name: "yorums",
                columns: table => new
                {
                    YorumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    yorum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    resim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    puan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yorums", x => x.YorumID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TurlarRUs_bolgeID",
                table: "TurlarRUs",
                column: "bolgeID");

            migrationBuilder.AddForeignKey(
                name: "FK_TurlarRUs_bolgeRUs_bolgeID",
                table: "TurlarRUs",
                column: "bolgeID",
                principalTable: "bolgeRUs",
                principalColumn: "bolgeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TurlarRUs_bolgeRUs_bolgeID",
                table: "TurlarRUs");

            migrationBuilder.DropTable(
                name: "yorums");

            migrationBuilder.DropIndex(
                name: "IX_TurlarRUs_bolgeID",
                table: "TurlarRUs");

            migrationBuilder.AddColumn<int>(
                name: "BolgeRUbolgeID",
                table: "TurlarRUs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TurlarRUs_BolgeRUbolgeID",
                table: "TurlarRUs",
                column: "BolgeRUbolgeID");

            migrationBuilder.AddForeignKey(
                name: "FK_TurlarRUs_bolgeRUs_BolgeRUbolgeID",
                table: "TurlarRUs",
                column: "BolgeRUbolgeID",
                principalTable: "bolgeRUs",
                principalColumn: "bolgeID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
