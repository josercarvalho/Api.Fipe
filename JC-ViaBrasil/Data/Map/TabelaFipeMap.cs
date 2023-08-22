using JC_ViaBrasil.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JC_ViaBrasil.Data.Map
{
    public class TabelaFipeMap : IEntityTypeConfiguration<TabelaFipe>
    {
        public void Configure(EntityTypeBuilder<TabelaFipe> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.valor).HasColumnType("varchar").HasMaxLength(50);
            builder.Property(x => x.marca).HasColumnType("varchar").HasMaxLength(100);
            builder.Property(x => x.modelo).HasColumnType("varchar").HasMaxLength(100);
            builder.Property(x => x.anoModelo).HasColumnType("integer");
            builder.Property(x => x.combustivel).HasColumnType("varchar").HasMaxLength(20);
            builder.Property(x => x.codigoFipe).HasColumnType("varchar").HasMaxLength(10);
            builder.Property(x => x.mesReferencia).HasColumnType("varchar").HasMaxLength(50);
            builder.Property(x => x.tipoVeiculo).HasColumnType("integer");
            builder.Property(x => x.siglaCombustivel).HasColumnType("varchar").HasMaxLength(1);
            builder.Property(x => x.dataConsulta).HasColumnType("varchar").HasMaxLength(150);
            builder.Property(x => x.placaVeiculo).HasColumnType("varchar").HasMaxLength(10);
        }
    }
}
