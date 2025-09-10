using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zimat.Inventarios.Core.ArticuloAggregate;

namespace Zimat.Inventarios.Infrastructure.Data.Config;

public class PrecioConfiguration : IEntityTypeConfiguration<Precio>
{
    public void Configure(EntityTypeBuilder<Precio> builder)
    {
        builder.Property(p => p.ImportePrecio)
            .HasPrecision(18, 4) // Precision and scale for decimal
            .IsRequired();

        builder.Property(p => p.FactorCosto)
            .HasPrecision(18, 6) // Precision and scale for decimal
            .IsRequired();

        builder.Property(x => x.Id).HasColumnType("uuid");

        builder.HasIndex(c => new { c.ArticuloUnidadId,c.NumeroLista}).IsUnique();

        /* builder.HasOne<ArticuloUnidad>()
            .WithMany()
            .HasForeignKey(x => x.ArticuloUnidadId)
            .OnDelete(DeleteBehavior.Restrict)
            .IsRequired(); */
    }
}