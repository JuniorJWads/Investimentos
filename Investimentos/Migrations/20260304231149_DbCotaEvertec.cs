using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Investimentos.Migrations
{
    /// <inheritdoc />
    public partial class DbCotaEvertec : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "Cotacao",
                newName: "valor");

            migrationBuilder.RenameColumn(
                name: "Indexador",
                table: "Cotacao",
                newName: "indexador");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "Cotacao",
                newName: "data");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Cotacao",
                newName: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "valor",
                table: "Cotacao",
                newName: "Valor");

            migrationBuilder.RenameColumn(
                name: "indexador",
                table: "Cotacao",
                newName: "Indexador");

            migrationBuilder.RenameColumn(
                name: "data",
                table: "Cotacao",
                newName: "Data");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Cotacao",
                newName: "ID");
        }
    }
}
