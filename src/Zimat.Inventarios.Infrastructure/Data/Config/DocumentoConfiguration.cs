using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zimat.Inventarios.Core.DocumentoAggregate;


namespace Zimat.Inventarios.Infrastructure.Data.Config;
public class DocumentoConfiguration : IEntityTypeConfiguration<Documento>
{
  public void Configure(EntityTypeBuilder<Documento> builder)
  {
    builder.HasMany<DocumentoConcepto>()
        .WithOne();
  }
}
