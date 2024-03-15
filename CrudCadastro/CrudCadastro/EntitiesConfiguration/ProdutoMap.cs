using CrudCadastro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CrudCadastro.EntitiesConfiguration
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
             .HasColumnType("VARCHAR")
             .HasMaxLength(500);

            builder.Property(x => x.Descricao)
             .HasColumnType("VARCHAR")
             .HasMaxLength(500);

            builder.Property(x => x.DataValidade)
             .HasColumnType("DATE")
             .HasMaxLength(20);

            builder.Property(x => x.Ativo)
             .HasColumnType("BIT")
             .HasMaxLength(3);

            builder.HasOne(x => x.Categoria)
             .WithMany(x => x.Produto)
             .HasForeignKey(x => x.Idcategoria)
             .HasConstraintName("FK_Categoria_Produto");
        }
    }
}
