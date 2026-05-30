using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Zimat.Inventarios.Core.ArticuloAggregate;
using Zimat.Inventarios.Core.UnidadAggregate;

namespace Zimat.Inventarios.Infrastructure.Data.Config;
public class ArticuloConfiguration : IEntityTypeConfiguration<Articulo>
{
  public void Configure(EntityTypeBuilder<Articulo> builder)
  {
    builder.Property(p => p.Descripcion)
        .HasMaxLength(DataSchemaConstants.DEFAULT_DESCRIPTION_LENGTH)
        .IsRequired();

    builder.Property(x => x.Id).HasColumnType("uuid");

    builder.HasMany(a => a.ArticuloUnidades)
        .WithOne()
        .HasForeignKey(au => au.ArticuloId)
        .OnDelete(DeleteBehavior.Cascade);

    builder.Navigation(a => a.ArticuloUnidades)
        .UsePropertyAccessMode(PropertyAccessMode.Field);

  }
}

