using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Djalma.Migrations
{
    /// <inheritdoc />
    public partial class FirstPopulaClientes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Clientes(Nome, Telefone, Email, CpfCnpj, VendedorId) VALUES('Afonso Padilha','1199992999', 'afonsopadilha@email.com.br', '111111111101', 1)");
            migrationBuilder.Sql("INSERT INTO Clientes(Nome, Telefone, Email, CpfCnpj, VendedorId) VALUES('Robson Fonseca','1199992998', 'robsinhograu@email.com', '111111111102', 1)");
            migrationBuilder.Sql("INSERT INTO Clientes(Nome, Telefone, Email, CpfCnpj, VendedorId) VALUES('Willian Albert Lima','1199992779', 'wlimaalbert@email.com.br', '111111111189',2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
