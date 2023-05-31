using Microsoft.EntityFrameworkCore.Migrations;

namespace Loja.API.Data.Migrations
{
    public partial class correcoes3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "Itens",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img",
                table: "Itens");
        }
    }
}
