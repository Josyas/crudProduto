using CrudCadastro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CrudCadastro.EntitiesConfiguration
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categoria");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
              .HasColumnType("VARCHAR")
              .HasMaxLength(500);

            builder.Property(x => x.Ativo)
              .HasColumnType("BIT")
              .HasMaxLength(3);
        }
    }
}
