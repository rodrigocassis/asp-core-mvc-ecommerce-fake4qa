using Microsoft.EntityFrameworkCore.Migrations;

namespace CasaDoCodigo.Migrations
{
    public partial class updateX : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CEP",
                table: "Cadastro");

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "Cadastro",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Cadastro");

            migrationBuilder.AddColumn<string>(
                name: "CEP",
                table: "Cadastro",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
