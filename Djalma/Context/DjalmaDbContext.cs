using Djalma.Models;
using Microsoft.EntityFrameworkCore;

namespace Djalma.Context
{
    public class DjalmaDbContext : DbContext
    {
        public DjalmaDbContext(DbContextOptions<DjalmaDbContext> options) : base(options)
        {

        }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
    }
}
