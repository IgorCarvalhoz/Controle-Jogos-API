using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Controle_Jogos_API.Migrations
{
    /// <inheritdoc />
    public partial class Atualizacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Horas",
                table: "Jogos",
                newName: "HorasJogadas");

            migrationBuilder.AlterColumn<string>(
                name: "AnoLancamento",
                table: "Jogos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HorasJogadas",
                table: "Jogos",
                newName: "Horas");

            migrationBuilder.AlterColumn<int>(
                name: "AnoLancamento",
                table: "Jogos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
