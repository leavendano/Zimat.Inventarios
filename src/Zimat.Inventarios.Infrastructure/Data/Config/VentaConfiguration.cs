using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zimat.Inventarios.Core.ClienteAggregate;

using Zimat.Inventarios.Core.VentaAggregate;


namespace Zimat.Inventarios.Infrastructure.Data.Config;
public class Configuration : IEntityTypeConfiguration<Venta>
{
  public void Configure(EntityTypeBuilder<Venta> builder)
  {
    
    builder.Property(x => x.Id).HasColumnType("uuid");
    builder.HasOne<Cliente>()
      .WithMany()
      .HasForeignKey(x => x.ClienteId)
      .OnDelete(DeleteBehavior.Restrict);
  }
}