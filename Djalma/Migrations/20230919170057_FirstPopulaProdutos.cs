using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Djalma.Migrations
{
    /// <inheritdoc />
    public partial class FirstPopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, MarcaId) VALUES('Arroz', 'Arroz branco, pacote de 1kg', 5.99, 1)");
            migrationBuilder.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, MarcaId) VALUES('Feijão', 'Feijão preto, pacote de 1kg', 4.49, 2)");
            migrationBuilder.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, MarcaId) VALUES('Macarrão', 'Macarrão espaguete, pacote de 500g', 3.99, 1)");
            migrationBuilder.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, MarcaId) VALUES('Tomate', 'Tomate vermelho, kg', 2.79, 3)");
            migrationBuilder.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, MarcaId) VALUES('Pão', 'Pão de forma, pacote de 500g', 4.99, 2)");
            migrationBuilder.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, MarcaId) VALUES('Leite', 'Leite integral, litro', 3.29, 1)");
            migrationBuilder.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, MarcaId) VALUES('Ovos', 'Ovos brancos, dúzia', 5.49, 3)");
            migrationBuilder.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, MarcaId) VALUES('Açúcar', 'Açúcar refinado, pacote de 1kg', 4.79, 2)");
            migrationBuilder.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, MarcaId) VALUES('Café', 'Café moído, pacote de 250g', 7.99, 1)");
            migrationBuilder.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, MarcaId) VALUES('Chocolate', 'Chocolate ao leite, barra de 100g', 3.49, 3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
