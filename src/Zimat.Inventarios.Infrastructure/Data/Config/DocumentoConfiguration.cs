using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zimat.Inventarios.Core.Base;
using Zimat.Inventarios.Core.DocumentoAggregate;


namespace Zimat.Inventarios.Infrastructure.Data.Config;
public class DocumentoConfiguration : IEntityTypeConfiguration<Documento>
{
  public void Configure(EntityTypeBuilder<Documento> builder)
  {
    // builder.Property(x => x.Id).HasConversion(
    //       x => x.Value,
    //       x => UuidV7.FromGuid(x)).HasColumnType("uuid");
    builder.Property(x => x.Id).HasColumnType("uuid");
  }
}
