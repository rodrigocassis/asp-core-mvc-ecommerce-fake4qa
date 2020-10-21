using Microsoft.EntityFrameworkCore.Migrations;

namespace CasaDoCodigo.Migrations
{
    public partial class newTable4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "SimpleForm");

            migrationBuilder.DropColumn(
                name: "CEP",
                table: "SimpleForm");

            migrationBuilder.DropColumn(
                name: "Complemento",
                table: "SimpleForm");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "SimpleForm");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "SimpleForm",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CEP",
                table: "SimpleForm",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Complemento",
                table: "SimpleForm",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "SimpleForm",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
