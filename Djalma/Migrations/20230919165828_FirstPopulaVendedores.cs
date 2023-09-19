using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Djalma.Migrations
{
    /// <inheritdoc />
    public partial class FirstPopulaVendedores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Vendedores(Nome, Email) VALUES('Emmily Roberta Brazilo','emily.vendas@email.com.br')");
            migrationBuilder.Sql("INSERT INTO Vendedores(Nome, Email) VALUES('Agusta dos Ceus','dosceus.vendas@email.com.br')");
            migrationBuilder.Sql("INSERT INTO Vendedores(Nome, Email) VALUES('Joao Araós','araósj.vendas@email.com.br')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
