using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class hizmet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "hizmet",
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
                    table.PrimaryKey("PK_hizmet", x => x.hizmetID);
                    table.ForeignKey(
                        name: "FK_hizmet_Turlars_turID",
                        column: x => x.turID,
                        principalTable: "Turlars",
                        principalColumn: "turID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_hizmet_turID",
                table: "hizmet",
                column: "turID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hizmet");
        }
    }
}
