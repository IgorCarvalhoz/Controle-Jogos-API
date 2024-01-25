using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Controle_Jogos_API.Migrations
{
    /// <inheritdoc />
    public partial class att2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UltimaAtualizacao",
                table: "Jogos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UltimaAtualizacao",
                table: "Jogos");
        }
    }
}
