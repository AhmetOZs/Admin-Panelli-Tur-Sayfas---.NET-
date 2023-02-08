using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class addmigrationana : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnaGirisENs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    arkaplan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    üstsatır = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    yer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    altsatır = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ucret = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnaGirisENs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AnaGirisRUs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    arkaplan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    üstsatır = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    yer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    altsatır = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ucret = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnaGirisRUs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AnaGirisTRs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    arkaplan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    üstsatır = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    yer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    altsatır = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ucret = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnaGirisTRs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Anas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TurlarKucukResim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YorumArkaResim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HakkimdaArkaResim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TurlarAcıklamaTR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GaleriAcıklamaTR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TurlarAcıklamaEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GaleriAcıklamaEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TurlarAcıklamaRU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GaleriAcıklamaRU = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anas", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnaGirisENs");

            migrationBuilder.DropTable(
                name: "AnaGirisRUs");

            migrationBuilder.DropTable(
                name: "AnaGirisTRs");

            migrationBuilder.DropTable(
                name: "Anas");
        }
    }
}
