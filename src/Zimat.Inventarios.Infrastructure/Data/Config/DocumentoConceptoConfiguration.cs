using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zimat.Inventarios.Core.DocumentoAggregate;


namespace Zimat.Inventarios.Infrastructure.Data.Config;
internal class DocumentoConceptoConfiguration : IEntityTypeConfiguration<DocumentoConcepto>
{
  public void Configure(EntityTypeBuilder<DocumentoConcepto> builder)
  {
    //builder.HasOne<Documento>()
    //    .WithMany()
    //    .HasForeignKey(x => x.DocumentoId);
  }
}
