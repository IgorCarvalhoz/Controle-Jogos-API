using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Controle_Jogos_API.Migrations
{
    /// <inheritdoc />
    public partial class Adicionar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnoJogado",
                table: "Jogos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AnoLancamento",
                table: "Jogos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnoJogado",
                table: "Jogos");

            migrationBuilder.DropColumn(
                name: "AnoLancamento",
                table: "Jogos");
        }
    }
}
