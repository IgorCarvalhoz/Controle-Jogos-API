using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Controle_Jogos_API.Migrations
{
    /// <inheritdoc />
    public partial class Avaliar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Avaliar",
                table: "Jogos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Avaliar",
                table: "Jogos");
        }
    }
}
