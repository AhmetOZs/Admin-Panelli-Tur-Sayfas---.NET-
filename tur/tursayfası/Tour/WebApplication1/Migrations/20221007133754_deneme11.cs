using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class deneme11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "telefon",
                table: "iletisims",
                newName: "telefonsabit");

            migrationBuilder.AddColumn<string>(
                name: "telefoncep",
                table: "iletisims",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "telefoncep",
                table: "iletisims");

            migrationBuilder.RenameColumn(
                name: "telefonsabit",
                table: "iletisims",
                newName: "telefon");
        }
    }
}
