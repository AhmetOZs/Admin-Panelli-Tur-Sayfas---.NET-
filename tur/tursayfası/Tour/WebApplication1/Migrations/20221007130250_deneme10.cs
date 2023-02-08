using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class deneme10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "iletisims",
                columns: table => new
                {
                    iletisimID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    konum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    facebook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    twitter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    instagram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    linkedin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    metintr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    metinen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    metinru = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fotaciklamatr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fotaciklamaen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fotaciklamaru = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_iletisims", x => x.iletisimID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "iletisims");
        }
    }
}
