using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class tarihe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "turTarihs",
                columns: table => new
                {
                    tarihID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tarih = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    turID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_turTarihs", x => x.tarihID);
                    table.ForeignKey(
                        name: "FK_turTarihs_Turlars_turID",
                        column: x => x.turID,
                        principalTable: "Turlars",
                        principalColumn: "turID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_turTarihs_turID",
                table: "turTarihs",
                column: "turID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "turTarihs");
        }
    }
}
