using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WaProject_API.ValueObjects;

namespace WaProject_API.Infra.EntityConfig
{
    public class ProdutoConfig : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {

            builder.ToTable("Produto");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).ValueGeneratedOnAdd();

            builder.Property(p => p.Nome).HasMaxLength(120).IsRequired();

            builder.Property(p => p.Descricao).HasMaxLength(255).IsRequired();

        }
    }
}
