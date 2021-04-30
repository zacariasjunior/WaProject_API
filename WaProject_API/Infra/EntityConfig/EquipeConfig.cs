using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WaProject_API.ValueObjects;

namespace WaProject_API.Infra.EntityConfig
{
    public class EquipeConfig : IEntityTypeConfiguration<Equipe>
    {
        public void Configure(EntityTypeBuilder<Equipe> builder)
        {

            builder.ToTable("Equipe");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.Nome).HasMaxLength(120).IsRequired();

            builder.Property(e => e.Descricao).HasMaxLength(255).IsRequired();

            builder.Property(e => e.PlacaDoVeiculo).HasMaxLength(10).IsRequired();

        }
    }
}
