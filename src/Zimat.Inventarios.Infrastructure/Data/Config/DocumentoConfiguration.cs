using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zimat.Inventarios.Core.ArticuloAggregate;
using Zimat.Inventarios.Core.Base;
using Zimat.Inventarios.Core.ClienteAggregate;
using Zimat.Inventarios.Core.DocumentoAggregate;
using Zimat.Inventarios.Core.ProveedorAggregate;


namespace Zimat.Inventarios.Infrastructure.Data.Config;
public class DocumentoConfiguration : IEntityTypeConfiguration<Documento>
{
  public void Configure(EntityTypeBuilder<Documento> builder)
  {
    
    builder.Property(x => x.Id).HasColumnType("uuid");
    builder.HasOne<Cliente>()
      .WithMany()
      .HasForeignKey(x => x.ClienteId)
      .OnDelete(DeleteBehavior.Restrict);

    builder.HasOne<Proveedor>()
      .WithMany()
      .HasForeignKey(x => x.ProveedorId)
      .OnDelete(DeleteBehavior.Restrict);
  }
}
