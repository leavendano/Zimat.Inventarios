using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zimat.Inventarios.Core.ClienteAggregate;
using Zimat.Inventarios.Core.CompraAggregate;
using Zimat.Inventarios.Core.ProveedorAggregate;


namespace Zimat.Inventarios.Infrastructure.Data.Config;
public class CompraConfiguration : IEntityTypeConfiguration<Compra>
{
  public void Configure(EntityTypeBuilder<Compra> builder)
  {

    builder.Property(x => x.Id).HasColumnType("uuid");
    
    builder.HasOne<Proveedor>()
      .WithMany()
      .HasForeignKey(x => x.ProveedorId)
      .OnDelete(DeleteBehavior.Restrict);
  }
}
