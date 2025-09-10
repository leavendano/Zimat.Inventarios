using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zimat.Inventarios.Core.ArticuloAggregate;
using Zimat.Inventarios.Core.UnidadAggregate;


namespace Zimat.Inventarios.Infrastructure.Data.Config;

public class ArticuloUnidadConfiguration : IEntityTypeConfiguration<ArticuloUnidad>
{
    public void Configure(EntityTypeBuilder<ArticuloUnidad> builder)
    {
        builder.Property(p => p.FactorConversion)
            .HasPrecision(18, 4) // Precision and scale for decimal
            .IsRequired();

        builder.Property(x => x.Id).HasColumnType("uuid");

        builder.HasOne<Articulo>()
            .WithMany()
            .HasForeignKey(x => x.ArticuloId)
            .OnDelete(DeleteBehavior.Restrict)
            .IsRequired();

        builder.HasOne<Unidad>()
            .WithMany()
            .HasForeignKey(x => x.UnidadId)
            .OnDelete(DeleteBehavior.Restrict)
            .IsRequired();

        builder.HasIndex(c => new { c.ArticuloId,c.UnidadId}).IsUnique();
    }
}