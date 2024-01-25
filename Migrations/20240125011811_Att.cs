using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Controle_Jogos_API.Migrations
{
    /// <inheritdoc />
    public partial class Att : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "HorasJogadas",
                table: "Jogos",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "HorasJogadas",
                table: "Jogos",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
