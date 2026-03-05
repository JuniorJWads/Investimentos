using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Investimentos.Migrations
{
    /// <inheritdoc />
    public partial class DbEvertec : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataCotacao",
                table: "Cotacao",
                newName: "Data");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Data",
                table: "Cotacao",
                newName: "DataCotacao");
        }
    }
}
