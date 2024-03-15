using CrudCadastro.EntitiesConfiguration;
using CrudCadastro.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudCadastro.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var conexao = "Data Source=localhost;Initial Catalog=crudCadastro;User ID=sa; MultipleActiveResultSets=true;Password=#sa123456@t$;TrustServerCertificate=True";
            options.UseSqlServer(conexao);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new CategoriaMap());
        }
    }
}
