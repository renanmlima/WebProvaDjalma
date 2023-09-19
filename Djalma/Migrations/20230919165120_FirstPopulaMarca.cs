using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Djalma.Migrations
{
    /// <inheritdoc />
    public partial class FirstPopulaMarca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Marcas(Nome, Pais) VALUES('Tudo Gostoso','Brasil')");
            migrationBuilder.Sql("INSERT INTO Marcas(Nome, Pais) VALUES('Saborous Food','United States')");
            migrationBuilder.Sql("INSERT INTO Marcas(Nome, Pais) VALUES('La Delicia','Mexico')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
