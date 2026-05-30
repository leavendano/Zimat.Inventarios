using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zimat.Inventarios.Core.ArticuloAggregate;
using Zimat.Inventarios.Core.KardexAggregate;

namespace Zimat.Inventarios.Infrastructure.Data.Config;

internal class KardexConfiguration : IEntityTypeConfiguration<Kardex>
{
  public void Configure(EntityTypeBuilder<Kardex> builder)
  {
    builder.Property(x => x.ArticuloId).HasColumnType("uuid");
    builder.Property(x => x.Id).HasColumnType("uuid");
    builder.Property(x => x.ReferenciaId).HasColumnType("uuid");
    builder.Property(x => x.CostoUnitario).HasPrecision(18, 6);
    builder.Property(x => x.CostoTotal).HasPrecision(18, 6);


    builder.HasOne<Articulo>()
        .WithMany()
        .HasForeignKey(x => x.ArticuloId)
        .OnDelete(DeleteBehavior.Restrict)
        .IsRequired();
  }
}