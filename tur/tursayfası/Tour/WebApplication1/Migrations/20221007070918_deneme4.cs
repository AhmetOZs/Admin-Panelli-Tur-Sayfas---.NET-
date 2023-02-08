using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class deneme4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DetayGorsel",
                columns: table => new
                {
                    DetayGorselID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetayResim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    turID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetayGorsel", x => x.DetayGorselID);
                    table.ForeignKey(
                        name: "FK_DetayGorsel_Turlars_turID",
                        column: x => x.turID,
                        principalTable: "Turlars",
                        principalColumn: "turID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetayGorsel_turID",
                table: "DetayGorsel",
                column: "turID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetayGorsel");
        }
    }
}
